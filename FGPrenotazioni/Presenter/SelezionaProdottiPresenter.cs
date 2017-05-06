using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models;
using FGPrenotazioni.View;
using System.Data;
using FGPrenotazioni.Models.Products;
using FGPrenotazioni.Models.Filters.FilterProducts;
using System.Windows.Forms;

namespace FGPrenotazioni.Presenter
{
    class SelezionaProdottiPresenter : Presenter
    {
        private List<Product> _listaFiltrata;
        private List<IFilterProducts> _listaFiltri;

        public SelezionaProdotti View
        {
            get
            {
                return (SelezionaProdotti)Element;
            }
        }

       

        public SelezionaProdottiPresenter(SelezionaProdotti view):base(view)
        {
            _listaFiltrata=FGManager.Instance.Warehouse.ProductList.Where(p => p.IsAvailable).ToList();
            _listaFiltri = new List<IFilterProducts>();
            PopulateView();
            View.AggiungiAlCarrelloButton.Click += onAggiungiClick;
            View.MostraCarrelloButton.Click += onMostraClick;
            View.ApplyButton.Click += onApplyClick;
            View.ResetButton.Click += onResetClick;
            FGManager.Instance.ShoppingCart.ProductsList.CollectionChanged += onPropertyChanged;
        }

        public void PopulateView()
        {
            
            View.ProductListDataGrid.DataSource = null;
            View.ProductListDataGrid.Rows.Clear();
            View.ProductListDataGrid.DataSource = _listaFiltrata;

            

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("FilterName");
            DataColumn dc2 = new DataColumn("FilterType");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);

           

            foreach (Type t in typeof(FiltroBaseProdotti).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FiltroBaseProdotti)) && !t.IsAbstract && t.Name!="FilterByStatus"))
            {
                dt.Rows.Add(t.Name, t);

            }

            View.FilterList.DataSource = dt;
            View.FilterList.DisplayMember = "FilterName";
            View.FilterList.ValueMember = "FilterType";

            View.FilterList.SelectedIndex = 0;

            View.FilterValue.Text = "";
          
        }

        public void onPropertyChanged(object sender, EventArgs e)
        {
            resetFlters();
           
        }

        public void onAggiungiClick(object sender,EventArgs e)
        {
            if (FGManager.Instance.Warehouse.ProductList.Count > 0 && _listaFiltrata.Count>0)
            {
                Product selected = View.ProductListDataGrid.SelectedRows[0].DataBoundItem as Product;
                FGManager.Instance.Warehouse.ProductList.Where(p => p.ProductCode == selected.ProductCode).First().IsAvailable = false;
                _listaFiltrata.Where(p => p.ProductCode == selected.ProductCode).First().IsAvailable = false;
                _listaFiltrata.Remove(_listaFiltrata.Where(p => p.ProductCode == selected.ProductCode).First());
                FGManager.Instance.ShoppingCart.AddProduct(selected);
                PopulateView();
            }else
            {
                MessageBox.Show("Magazzino Vuoto");
            }
        }

        public void onMostraClick(object sender,EventArgs e)
        {
            if (FGManager.Instance.ShoppingCart.ProductsList.Count == 0) MessageBox.Show("Carrello vuoto!", "SHOPPING CART", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else GestoreView.GetInstance().MostraView(typeof(ShopppingCartForm), typeof(ShoppingCartPresenter));
        }

        public void onApplyClick(object sender,EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(View.FilterValue.Text))
            {
                MessageBox.Show("Filtro vuoto!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_listaFiltri.Where(f=>f.GetType()==Type.GetType(View.FilterList.SelectedValue.ToString())).ToList().Count!=0)
            {
                MessageBox.Show("Impossibile applicare due volte lo stesso filtro!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {

                string param = View.FilterValue.Text;

                object[] constructiorArgs = new object[2];

                if (_listaFiltri.Count() == 0)
                {
                    constructiorArgs[0] = FiltroBaseProdotti.FiltroDiTutto;
                    constructiorArgs[1] = param;
                }
                else
                {
                    constructiorArgs[0] = _listaFiltri.Last();
                    constructiorArgs[1] = param;
                }

                Type selected = Type.GetType(View.FilterList.SelectedValue.ToString());
                FiltroBaseProdotti filter = (FiltroBaseProdotti)Activator.CreateInstance(selected, constructiorArgs);
                _listaFiltrata = filter.GetProdotti().Where(p => p.IsAvailable).ToList();
                _listaFiltri.Add(filter);

                View.ListaFiltriView.Items.Add(selected.Name + " : " + param);


                PopulateView();
            }
        }

        public void onResetClick(object sender,EventArgs e)
        {
            resetFlters();
        }

        public void resetFlters()
        {
            View.ListaFiltriView.Items.Clear();
            _listaFiltri.Clear();
            _listaFiltrata = FGManager.Instance.Warehouse.ProductList.Where(p => p.IsAvailable).ToList();
            PopulateView();
        }
    }

}
