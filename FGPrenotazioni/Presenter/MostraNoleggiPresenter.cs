using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Filters.FilterRent;
using FGPrenotazioni.Models.GoodsMovements;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.Products;
using FGPrenotazioni.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Presenter
{
    class MostraNoleggiPresenter : Presenter
    {
        private List<Rent> _listaFiltrata;
        private List<IFilterRent> _listaFiltri;
        public MostraNoleggi View
        {
            get { return (MostraNoleggi)Element; }
        }
        public MostraNoleggiPresenter(MostraNoleggi view) : base(view)
        {
            _listaFiltrata = FGManager.Instance.RentsRiepilogue.GetAll.ToList();
            _listaFiltri = new List<IFilterRent>();
            PopulateView();
            View.ShowNolo.Click += OnMostraNoleggio;
            View.RitornaMerce.Click += OnRitornaMerce;
            View.ApplicaFiltri.Click += OnApplicaFiltri;
            View.ResetFilitri.Click += onClearFilter;
        }

        private void onClearFilter(object sender, EventArgs e)
        {
            View.ListaFilitri.Items.Clear();
            _listaFiltri.Clear();
            _listaFiltrata = FGManager.Instance.RentsRiepilogue.GetAll.ToList();
            PopulateView();
        }

        public void OnApplicaFiltri(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(View.TextFiltri.Text))
            {
                MessageBox.Show("Filtro vuoto!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_listaFiltri.Where(f => f.GetType() == Type.GetType(View.ComboFilitri.SelectedValue.ToString())).ToList().Count != 0)
            {
                MessageBox.Show("Impossibile applicare due volte lo stesso filtro!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string param = View.TextFiltri.Text;

                object[] constructiorArgs = new object[2];

                if (_listaFiltri.Count() == 0)
                {
                    constructiorArgs[0] = FiltroBaseRent.FiltroDiTutto;
                    constructiorArgs[1] = param;
                }
                else
                {
                    constructiorArgs[0] = _listaFiltri.Last();
                    constructiorArgs[1] = param;
                }

                Type selected = Type.GetType(View.ComboFilitri.SelectedValue.ToString());
                FiltroBaseRent filter = (FiltroBaseRent)Activator.CreateInstance(selected, constructiorArgs);
                _listaFiltrata = filter.GetRent().ToList();
                _listaFiltri.Add(filter);

                View.ListaFilitri.Items.Add(selected.Name + " : " + param);

                PopulateView();
            }

        }
        private void PopulateView()
        {
            View.DataGridViewNolo.DataSource = null;
            View.DataGridViewNolo.Rows.Clear();
            View.DataGridViewNolo.DataSource = _listaFiltrata;

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("FilterName");
            DataColumn dc2 = new DataColumn("FilterType");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);



            foreach (Type t in typeof(FiltroBaseRent).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FiltroBaseRent)) && !t.IsAbstract))
            {
                dt.Rows.Add(t.Name, t);

            }

            View.ComboFilitri.DataSource = dt;
            View.ComboFilitri.DisplayMember = "FilterName";
            View.ComboFilitri.ValueMember = "FilterType";

            View.ComboFilitri.SelectedIndex = 0;

            View.TextFiltri.Text = "";

        }
        public void OnRitornaMerce(object sender, EventArgs e)
        {
            try
            {
                if (FGManager.Instance.RentsRiepilogue.GetAll.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(View.Discount.Text))
                        View.Discount.Text = "0";
                    Rent ritornoRent = View.DataGridViewNolo.SelectedRows[0].DataBoundItem as Rent;
                    double sconto = double.Parse(View.Discount.Text);
                    Invoice generated = FGManager.Instance.InvoiceGenerator(ritornoRent, View.isPagato.Checked, sconto, FGManager.Instance.CostumerRiepilogue.GetAll.Where(s => s.ID == ritornoRent.Custumer).ToList().First(), FGManager.Instance.Logged, View.isPerc.Checked);

                    FGManager.Instance.InvoicesRiepilogue.Add(generated);

                    foreach (Product p in ritornoRent.ProductsToMove)
                    {
                        FGManager.Instance.Warehouse.ProductList.Where(pr => p.ProductCode == pr.ProductCode).ToList().First().IsAvailable = true;
                        FGManager.Instance.Warehouse.ProductList.Where(pr => p.ProductCode == pr.ProductCode).ToList().First().IsNew = false;
                    }
                    FGManager.Instance.RentsRiepilogue.Remove(ritornoRent);
                    MessageBox.Show(generated.toFullString());
                    MessageBox.Show("Rientro noleggio andato a buon fine");
                    _listaFiltrata.Remove(ritornoRent);
                    PopulateView();
                }else
                {
                    MessageBox.Show("Nessun noleggio da rientrare!", "NOLEGGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nel rientro del Noleggio");
            }
        }
        public void OnMostraNoleggio(object sender ,EventArgs e)
        {
            if (FGManager.Instance.RentsRiepilogue.GetAll.Count>0) {
                try
                {
                    Rent thisRent = View.DataGridViewNolo.SelectedRows[0].DataBoundItem as Rent;
                    if (string.IsNullOrWhiteSpace(View.Discount.Text))
                        View.Discount.Text = "0";
                    double sconto = double.Parse(View.Discount.Text);
                    Invoice generated = FGManager.Instance.InvoiceGenerator(thisRent, View.isPagato.Checked, sconto, FGManager.Instance.CostumerRiepilogue.GetAll.Where(s => s.ID == thisRent.Custumer).ToList().First(), FGManager.Instance.Logged, View.isPerc.Checked);

                    MessageBox.Show(thisRent.toFullString()+Environment.NewLine+"Totale: "+generated.Amount+ CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sconto non valido");
                }
            }
            else
            {
                MessageBox.Show("Nessun noleggio da mostrare", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
