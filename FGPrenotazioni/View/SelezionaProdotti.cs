using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.Presenter;

namespace FGPrenotazioni.View
{
    public partial class SelezionaProdotti : UserControl
    {

        public SelezionaProdotti()
        {
            InitializeComponent();
          
        }

        public Button MostraCarrelloButton
        {
            get
            {
                return mostraButton;
            }
        }
        public Button AggiungiAlCarrelloButton
        {
            get
            {
                return aggiungiButton;
            }
        }
        public DataGridView ProductListDataGrid
        {
            get
            {
                return productListDataGrid;
            }
        }
        public ComboBox FilterList
        {
            get
            {
                return filterListCombo;
            }
        }
        public TextBox FilterValue
        {
            get
            {
                return filterValueText;
            }
        }
        public Button ApplyButton
        {
            get
            {
                return applyButton;
            }
        }
        public ListView ListaFiltriView
        {
            get
            {
                return listaFiltri;
            }
        }
        public Button ResetButton
        {
            get
            {
                return resetButton;
            }
        }
    }
}
