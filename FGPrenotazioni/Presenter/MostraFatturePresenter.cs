using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Filters.FilterInvoices;
using FGPrenotazioni.Models.Filters.FiltersInvoices;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Presenter
{
    class MostraFatturePresenter : Presenter
    {
        private List<Invoice> _listaFiltrata;
        private List<IFilterInvoices> _listaFiltri;
        public MostraFatture View
        {
            get
            {
                return (MostraFatture)Element;
            }
        }
        public MostraFatturePresenter(MostraFatture view) : base(view)
        {
            _listaFiltrata = FGManager.Instance.InvoicesRiepilogue.GetAll.ToList();
            _listaFiltri = new List<IFilterInvoices>();
            PopulateView();
            View.MostraFattura.Click += OnMostraFattura;
            View.Applica.Click += onApplyFilterClick;
            View.Reset.Click += onClearFilter;
        }

        private void PopulateView()
        {
            DataTable dt2 = new DataTable();
            DataColumn dc1g = new DataColumn("Progressive Number");
            DataColumn dc2g = new DataColumn("Pagata",typeof(bool));
            DataColumn dc3g = new DataColumn("Data Emissione",typeof(DateTime));
            DataColumn dc4g = new DataColumn("Amount");
            DataColumn dc5g = new DataColumn("Impiegato");
            DataColumn dc6g = new DataColumn("Customer");
            dt2.Columns.Add(dc1g);
            dt2.Columns.Add(dc2g);
            dt2.Columns.Add(dc3g);
            dt2.Columns.Add(dc4g);
            dt2.Columns.Add(dc5g);
            dt2.Columns.Add(dc6g);


            foreach (Invoice t in _listaFiltrata)
            {
                dt2.Rows.Add(t.ProgressiveNumber,t.ToPay,t.EmissionDate, t.Amount,t.Employee,t.Subject.ID);
            }
            
            
            View.DataGridFatture.DataSource = null;
            View.DataGridFatture.Rows.Clear();
            View.DataGridFatture.DataSource = dt2;
           


            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("FilterName");
            DataColumn dc2 = new DataColumn("FilterType");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);


            foreach (Type t in typeof(FiltroBaseInvoices).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FiltroBaseInvoices)) && !t.IsAbstract))
            {
                dt.Rows.Add(t.Name, t);

            }

            View.ComboFiltri.DataSource = dt;
            View.ComboFiltri.DisplayMember = "FilterName";
            View.ComboFiltri.ValueMember = "FilterType";

            View.ComboFiltri.SelectedIndex = 0;

            View.Filtro.Text = "";
        }

        public void onClearFilter(object sender, EventArgs e)
        {
            resetFlters();
        }
        public void resetFlters()
        {
            View.FiltriApplicati.Items.Clear();
            _listaFiltri.Clear();
            _listaFiltrata = FGManager.Instance.InvoicesRiepilogue.GetAll.ToList();
            PopulateView();
        }
        public void onApplyFilterClick(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(View.Filtro.Text))
                {
                    MessageBox.Show("Filtro vuoto!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (_listaFiltri.Where(f => f.GetType() == Type.GetType(View.ComboFiltri.SelectedValue.ToString())).ToList().Count != 0)
                {
                    MessageBox.Show("Impossibile applicare due volte lo stesso filtro!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string param = View.Filtro.Text;

                    object[] constructiorArgs = new object[2];

                    if (_listaFiltri.Count() == 0)
                    {
                        constructiorArgs[0] = FiltroBaseInvoices.FiltroDiTutto;
                        constructiorArgs[1] = param;
                    }
                    else
                    {
                        constructiorArgs[0] = _listaFiltri.Last();
                        constructiorArgs[1] = param;
                    }

                    Type selected = Type.GetType(View.ComboFiltri.SelectedValue.ToString());
                    FiltroBaseInvoices filter = (FiltroBaseInvoices)Activator.CreateInstance(selected, constructiorArgs);
                    _listaFiltrata = filter.GetInvoices().ToList();
                    _listaFiltri.Add(filter);

                    View.FiltriApplicati.Items.Add(selected.Name + " : " + param);

                    PopulateView();
                }
            }catch(Exception er){
                MessageBox.Show("Errore nell applicazione dei filtri" + er.StackTrace);
            }
            

        }

        public void OnMostraFattura(object sender, EventArgs e)
        {
            List<Invoice> thisInvoices = FGManager.Instance.InvoicesRiepilogue.GetAll.ToList();
            Invoice thisInvoice = thisInvoices.Where(s => View.DataGridFatture.SelectedCells[0].Value.ToString() == s.ProgressiveNumber.ToString()).First();
            MessageBox.Show(thisInvoice.toFullString());
        }
    }
}
