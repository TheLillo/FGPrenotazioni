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
    public partial class MostraFatture : UserControl
    {
        
        public MostraFatture()
        {
            InitializeComponent();
            
        }

        public Button Applica
        {
            get
            {
                return buttonApplicaFiltro;
            }
        }
        public Button Reset
        {
            get
            {
                return buttonRestFiltro;
            }
        }
        public Button MostraFattura
        {
            get
            {
                return buttonShowFattura;
            }
        }
        public ComboBox ComboFiltri
        {
            get
            {
                return comboBoxFilterFatture;
            }
        }

        public TextBox Filtro
        {
            get
            {
                return textBoxFiltroFatture;
            }
        }

        public ListView FiltriApplicati
        {
            get
            {
                return listViewFiltriApplicati;
            }
        }

        public DataGridView DataGridFatture
        {
            get
            {
                return dataGridViewFatture;
            }
        }
    }
}
