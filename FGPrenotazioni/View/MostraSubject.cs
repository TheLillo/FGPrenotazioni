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
    public partial class MostraSubject : UserControl
    {
      
        public MostraSubject()
        {
            InitializeComponent();
        }


        public Button ApplyFilter
        {
            get
            {
                return applicaFiltroSubject;
            }
        }

        public Button ClearFilter
        {
            get
            {
                return ClearSubjectFilter;
            }
        }
        public ListView ListaFiltriApply
        {
            get
            {
                return listaApplyFilter;
            }
        }
        public ComboBox ComboFiltriSubject
        {
            get
            {
                return comboBoxFiltriSubject;
            }
        }

        public TextBox Filtro
        {
            get
            {
                return filterText;
            }
        }

        public Button AggiungiSubject
        {
            get
            {
                return aggiungiSubject;
            }
        }
        public Button RimuoviCliente
        {
            get
            {
                return buttonRimuovi;
            }
        }
        public DataGridView SubjectGridView
        {
            get
            {
                return dataGridSubject;
            }
        }
    }
}
