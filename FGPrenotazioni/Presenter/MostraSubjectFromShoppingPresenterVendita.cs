using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.GoodsMovements;
using System.Globalization;
using System.Data;
using FGPrenotazioni.Models.Filters.FilterCostumer;
using FGPrenotazioni.Models.Products;
using FGPrenotazioni.Models.Invoices;
using System.Collections.Specialized;

namespace FGPrenotazioni.Presenter
{
    class MostraSubjectFromShoppingPresenterVendita : Presenter
    {
        private List<Customer> _listaFiltrata;
        private List<IFilterCostumer> _listaFiltri;

        public MostraSubAfterShoppingVendita View
        {
            get { return (MostraSubAfterShoppingVendita)Element; }
        }
        public MostraSubjectFromShoppingPresenterVendita(MostraSubAfterShoppingVendita element) : base(element)
        {
            _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList(); ;
            _listaFiltri = new List<IFilterCostumer>();
            PopulateView();
            View.InditetroButton.Click += onIndietroClick;
            View.ProcediVendita.Click += onProcediClick;
            View.MostraSubject.AggiungiSubject.Click += onAggiungiClick;  
            View.Sconto.TextChanged += OnTextChange;
            View.ScontoPercentuale.CheckedChanged += OnCheckChange;
          
        }

      

        private void UpdateTotal()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(View.Sconto.Text))
                    View.Sconto.Text = "0";
                double sconto = double.Parse(View.Sconto.Text);

                if (View.ScontoPercentuale.Checked)
                {
                    View.TotaleLabel.Text = "Totale: " + Services.CalculateAmountWithDiscount(Services.CalculateAmount(new Sell(new List<Product>(FGManager.Instance.ShoppingCart.ProductsList), DateTime.Now)) , Services.CalculateDiscountPerc(sconto, Services.CalculateAmount(new Sell(new List<Product>(FGManager.Instance.ShoppingCart.ProductsList), DateTime.Now)))) + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

                }
                else
                {
                    View.TotaleLabel.Text = "Totale: " + Services.CalculateAmountWithDiscount(Services.CalculateAmount(new Sell(new List<Product>(FGManager.Instance.ShoppingCart.ProductsList), DateTime.Now)), sconto) + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol; 
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Valore sconto non valido");
                View.Sconto.Text = "0";
            }
        }
        public void OnCheckChange(object sender, EventArgs e)
        {
            UpdateTotal();
        }
        public void OnTextChange(object sender, EventArgs e)
        {
            UpdateTotal();           
        }

        public void onIndietroClick(object sender,EventArgs e)
        {
            foreach(Product p in FGManager.Instance.ShoppingCart.ProductsList)
            {
                FGManager.Instance.Warehouse.ProductList.Where(pr => pr.ProductCode == p.ProductCode).First().IsAvailable = true;

            }
            FGManager.Instance.ShoppingCart.EmptyShoppingCart();
           
            GestoreView.GetInstance().MostraView(typeof(MainPage), typeof(MainPagePresenter));
            GestoreView.GetInstance().ChiudiView(typeof(MostraSubAfterShoppingVendita));

        }
        public void onProcediClick(object sender, EventArgs e)
        {
            try
            {
                if ((View.MostraSubject.SubjectGridView.SelectedRows[0].DataBoundItem as Customer).Reliable)
                {
                    double sconto = double.Parse(View.Sconto.Text);
                    Customer selectedSubject = View.MostraSubject.SubjectGridView.SelectedRows[0].DataBoundItem as Customer;
                    Invoice generated = FGManager.Instance.InvoiceGenerator(new Sell(new List<Product>(FGManager.Instance.ShoppingCart.ProductsList), DateTime.Now), View.Pagato.Checked, sconto, selectedSubject, FGManager.Instance.Logged, View.ScontoPercentuale.Checked);

                    FGManager.Instance.InvoicesRiepilogue.Add(generated);

                    foreach (Product p in FGManager.Instance.ShoppingCart.ProductsList)
                    {
                        FGManager.Instance.Warehouse.RemoveProduct(p);
                    }

                    FGManager.Instance.ShoppingCart.EmptyShoppingCart();

                    MessageBox.Show(generated.toFullString());
                    MessageBox.Show("Inserimento andato a buon fine");

                    GestoreView.GetInstance().MostraView(typeof(MainPage), typeof(MainPagePresenter));
                    GestoreView.GetInstance().ChiudiView(typeof(MostraSubAfterShoppingVendita));
                }
                else {
                    MessageBox.Show("Impossibile servire dei servizi a questo cliente");
                }

            } catch(Exception)
            {
                MessageBox.Show("Errore nella generazione della fattura");
            }
           
           

        }
        public void onAggiungiClick(object sender, EventArgs e)
        {
            
            GestoreView.GetInstance().MostraView(typeof(InsertNewCustumer), typeof(InsertNewCostumerPresenter));
            GestoreView.GetInstance().NascondiView(typeof(MostraSubAfterShoppingVendita));
        }
        private void RowPaint(object sender, EventArgs args)
        {
            foreach (DataGridViewRow r in View.MostraSubject.SubjectGridView.Rows)
            {

                if (!(r.DataBoundItem as Customer).Reliable)
                {
                    r.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void PopulateView()
        {
            View.MostraSubject.SubjectGridView.DataSource = null;
            View.MostraSubject.SubjectGridView.Rows.Clear();
            View.MostraSubject.SubjectGridView.DataSource = _listaFiltrata;
            View.MostraSubject.SubjectGridView.RowPostPaint += RowPaint;

            UpdateTotal();

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("FilterName");
            DataColumn dc2 = new DataColumn("FilterType");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);



            foreach (Type t in typeof(FiltroBaseCostumer).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FiltroBaseCostumer)) && !t.IsAbstract))
            {
                dt.Rows.Add(t.Name, t);

            }

            View.MostraSubject.ComboFiltriSubject.DataSource = dt;
            View.MostraSubject.ComboFiltriSubject.DisplayMember = "FilterName";
            View.MostraSubject.ComboFiltriSubject.ValueMember = "FilterType";

            View.MostraSubject.ComboFiltriSubject.SelectedIndex = 0;

            View.MostraSubject.Filtro.Text = "";



        }

    
    }
}
