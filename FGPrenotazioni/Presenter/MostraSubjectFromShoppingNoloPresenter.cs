using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Filters.FilterCostumer;
using FGPrenotazioni.Models.Products;
using System.Data;
using FGPrenotazioni.Models.GoodsMovements;
using System.Globalization;
using FGPrenotazioni.Models.Riepilogues;
using System.Collections.Specialized;

namespace FGPrenotazioni.Presenter
{
    class MostraSubjectFromShoppingNoloPresenter : Presenter
    {
        private List<Customer> _listaFiltrata;
        private List<IFilterCostumer> _listaFiltri;

        public MostraSubAfterShoppingNolo View
        {
            get { return (MostraSubAfterShoppingNolo)Element; }
        }
        public MostraSubjectFromShoppingNoloPresenter(MostraSubAfterShoppingNolo element) : base(element)
        {
            _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList();
            _listaFiltri = new List<IFilterCostumer>();
            PopulateView();
           
            View.IndietroButton.Click += onIndietroClick;
            View.ProcediButton.Click += onProcediClick;
            View.MostraSubject.AggiungiSubject.Click += onAggiungiClick;
            View.InizioTime.ValueChanged += onDateChanged;
            View.FineTime.ValueChanged += onDateChanged;
            View.ScontoTextBox.TextChanged += OnTextChange;
            View.IsPercentuale.CheckedChanged += OnCheckChange;
           
        }

      

        public void OnCheckChange(object sender, EventArgs e)
        {
            UpdateTotal();
        }
        public void OnTextChange(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        public void onIndietroClick(object sender, EventArgs e)
        {
            foreach (Product p in FGManager.Instance.ShoppingCart.ProductsList)
            {
                FGManager.Instance.Warehouse.ProductList.Where(pr => pr.ProductCode == p.ProductCode).First().IsAvailable = true;

            }

            FGManager.Instance.ShoppingCart.EmptyShoppingCart();
          
            GestoreView.GetInstance().MostraView(typeof(MainPage),typeof(MainPagePresenter));
            GestoreView.GetInstance().ChiudiView(typeof(MostraSubAfterShoppingNolo));

        }
        public void onDateChanged(object sender, EventArgs e)
        {
            if (View.InizioTime.Value > View.FineTime.Value || View.FineTime.Value < View.InizioTime.Value)
            {
                MessageBox.Show("Inizio noleggio deve essere minore di fine noleggio");

                View.FineTime.Value = View.InizioTime.Value.AddDays(1);
                View.InizioTime.Value = DateTime.Now;
                View.FineTime.Value = DateTime.Now.AddDays(1);
                PopulateView();
            }
            else
                UpdateTotal();
        }
        public void onProcediClick(object sender, EventArgs e)
        {
            try
            {
                if ((View.MostraSubject.SubjectGridView.SelectedRows[0].DataBoundItem as Customer).Reliable)
                {
                    double sconto = double.Parse(View.ScontoTextBox.Text);
                    Customer selectedSubject = View.MostraSubject.SubjectGridView.SelectedRows[0].DataBoundItem as Customer;
                    List<Product> shoppingcart = new List<Product>(FGManager.Instance.ShoppingCart.ProductsList);

                    Rent generated = new Rent(shoppingcart, View.InizioTime.Value.Date, View.FineTime.Value.Date, Services.CalculateRentCode(), selectedSubject);

                    FGManager.Instance.RentsRiepilogue.Add(generated);


                    FGManager.Instance.ShoppingCart.EmptyShoppingCart();

                    MessageBox.Show(generated.toFullString());
                    MessageBox.Show("Noleggio andato a buon fine");



                    GestoreView.GetInstance().MostraView(typeof(MainPage), typeof(MainPagePresenter));
                    GestoreView.GetInstance().ChiudiView(typeof(MostraSubAfterShoppingNolo));
                }
                else
                {
                    MessageBox.Show("Impossibile offire dei servizi a questo cliente");
                                     
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nella generazione del noleggio");
            }

         

        }
        public void onAggiungiClick(object sender, EventArgs e)
        {
            GestoreView.GetInstance().MostraView(typeof(InsertNewCustumer), typeof(InsertNewCostumerPresenter));

            GestoreView.GetInstance().NascondiView(typeof(MostraSubAfterShoppingNolo));
        }

        private void UpdateTotal()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(View.ScontoTextBox.Text))
                    View.ScontoTextBox.Text = "0";
                double sconto = double.Parse(View.ScontoTextBox.Text);
                DateTime inizio = View.InizioTime.Value.Date;
                DateTime fine = View.FineTime.Value.Date;
                string rentCode = Services.CalculateRentCode();
                View.MostraSubject.SubjectGridView.Rows[0].Selected = true;
                Customer selectedSubject = View.MostraSubject.SubjectGridView.SelectedRows[0].DataBoundItem as Customer;
                List<Product> shoppingcart = new List<Product>(FGManager.Instance.ShoppingCart.ProductsList);

                if (View.IsPercentuale.Checked)
                {
                    View.TotaleLabel.Text = "Totale: " + Services.CalculateAmountWithDiscount(Services.CalculateAmount(new Rent(shoppingcart, inizio, fine, rentCode, selectedSubject)), Services.CalculateDiscountPerc(sconto, Services.CalculateAmount(new Rent(shoppingcart, inizio, fine, rentCode, selectedSubject)))) + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

                }
                else
                {
                    View.TotaleLabel.Text = "Totale: " + Services.CalculateAmountWithDiscount(Services.CalculateAmount(new Rent(shoppingcart, inizio, fine, rentCode, selectedSubject)), sconto) + CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
                }
            }catch(Exception)
            {
                MessageBox.Show("Valore dello sconto non valido");
                View.ScontoTextBox.Text = "0";
            }
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

