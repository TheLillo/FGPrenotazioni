using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Filters.FilterCostumer;
using System.Data;
using FGPrenotazioni.Models.GoodsMovements;

namespace FGPrenotazioni.Presenter
{
    class MostraSubjectPresenter : Presenter
    {
        private List<Customer> _listaFiltrata;
        private List<IFilterCostumer> _listaFiltri;
        public MostraSubject View
        {
            get { return (MostraSubject)Element; }
        }
        public MostraSubjectPresenter(MostraSubject element) : base(element)
        {
            _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList();
            _listaFiltri = new List<IFilterCostumer>();
            PopulateView();
            View.RimuoviCliente.Click += OnRimuoviCliente;
            View.ClearFilter.Click += onClearFilter;
            View.ApplyFilter.Click += onApplyFilterClick;
            View.AggiungiSubject.Click += OnAddSubject;
            FGManager.Instance.CostumerRiepilogue.GetAll.CollectionChanged += onAddedCustumer;
        }
        private void OnRimuoviCliente(object sender, EventArgs args)
        {
            bool find = false;
            if (FGManager.Instance.CostumerRiepilogue.GetAll.Count > 0)
            {
                foreach (Rent r in FGManager.Instance.RentsRiepilogue.GetAll.ToList())
                {
                    if (View.SubjectGridView.SelectedRows[0].Cells["ID"].Value.ToString() == r.Custumer)
                    {
                        find = true;
                        MessageBox.Show("Questo cliente ha un noleggio attivo pertanto non può essere rimosso");
                        break;
                    }
                }
                if (!find)
                {
                    foreach (Customer c in FGManager.Instance.CostumerRiepilogue.GetAll)
                    {
                        if (View.SubjectGridView.SelectedRows[0].Cells["ID"].Value.ToString() == c.ID)
                        {
                            FGManager.Instance.CostumerRiepilogue.Remove(c);
                            break;
                        }
                    }
                    _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList();
                    PopulateView();
                }
            }
            else
            {
                MessageBox.Show("Elenco Clienti vuoto");
            }
        }
        private void onAddedCustumer(object sender, EventArgs args)
        {
            _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList();
            PopulateView();
        }

        private void RowPaint(object sender, EventArgs args)
        {
            foreach (DataGridViewRow r in View.SubjectGridView.Rows)
            {
              
                if ((r.Cells["Reliable"].Value.ToString()=="False"))
                {
                    r.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
      

        private void PopulateView()
        {
            DataTable dt2 = new DataTable();
            DataColumn dc1g = new DataColumn("ID");
            DataColumn dc2g = new DataColumn("Credit Card");
            DataColumn dc3g = new DataColumn("Denomination");
            DataColumn dc4g = new DataColumn("EMail");
            DataColumn dc5g = new DataColumn("PhoneNumber");
            DataColumn dc6g = new DataColumn("Reliable",typeof(bool));
            DataColumn dc7g = new DataColumn("Tipologia");
            DataColumn dc8g = new DataColumn("Address");
            dt2.Columns.Add(dc1g);
            dt2.Columns.Add(dc2g);
            dt2.Columns.Add(dc3g);
            dt2.Columns.Add(dc4g);
            dt2.Columns.Add(dc5g);
            dt2.Columns.Add(dc6g);
            dt2.Columns.Add(dc7g);
            dt2.Columns.Add(dc8g);


            foreach (Customer t in _listaFiltrata)
            {
                dt2.Rows.Add(t.ID, t.CreditCard, t.Denomination, t.EMail, t.PhoneNumber, t.Reliable,t.Tipologia,t.Address.Street+" "+t.Address.Location);
            }


            View.SubjectGridView.DataSource = null;
            View.SubjectGridView.Rows.Clear();
            View.SubjectGridView.DataSource = dt2;
            View.SubjectGridView.RowPostPaint += RowPaint;

           

           

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("FilterName");
            DataColumn dc2 = new DataColumn("FilterType");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            

            foreach (Type t in typeof(FiltroBaseCostumer).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(FiltroBaseCostumer)) && !t.IsAbstract))
            {
                dt.Rows.Add(t.Name, t);
            }

            View.ComboFiltriSubject.DataSource = dt;
            View.ComboFiltriSubject.DisplayMember = "FilterName";
            View.ComboFiltriSubject.ValueMember = "FilterType";

            View.ComboFiltriSubject.SelectedIndex = 0;
           
            View.Filtro.Text = "";
        }
        public void onClearFilter(object sender, EventArgs e)
        {
            resetFlters();
        }
        public void onApplyFilterClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(View.Filtro.Text))
            {
                MessageBox.Show("Filtro vuoto!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_listaFiltri.Where(f => f.GetType() == Type.GetType(View.ComboFiltriSubject.SelectedValue.ToString())).ToList().Count != 0)
            {
                MessageBox.Show("Impossibile applicare due volte lo stesso filtro!", "FILTER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string param = View.Filtro.Text;

                object[] constructiorArgs = new object[2];

                if (_listaFiltri.Count() == 0)
                {
                    constructiorArgs[0] = FiltroBaseCostumer.FiltroDiTutto;
                    constructiorArgs[1] = param;
                }
                else
                {
                    constructiorArgs[0] = _listaFiltri.Last();
                    constructiorArgs[1] = param;
                }

                Type selected = Type.GetType(View.ComboFiltriSubject.SelectedValue.ToString());
                FiltroBaseCostumer filter = (FiltroBaseCostumer)Activator.CreateInstance(selected, constructiorArgs);
                _listaFiltrata = filter.GetCostumer().ToList();
                _listaFiltri.Add(filter);

                View.ListaFiltriApply.Items.Add(selected.Name + " : " + param);

                PopulateView();
            }
        }

        public void resetFlters()
        {
            View.ListaFiltriApply.Items.Clear();
            _listaFiltri.Clear();
            _listaFiltrata = FGManager.Instance.CostumerRiepilogue.GetAll.ToList(); ;
            PopulateView();
        }

        public void OnAddSubject(object sender, EventArgs e)
        {
            GestoreView.GetInstance().MostraView(typeof(InsertNewCustumer), typeof(InsertNewCostumerPresenter));
            GestoreView.GetInstance().NascondiView(typeof(MainPage));
        }
    }
}
