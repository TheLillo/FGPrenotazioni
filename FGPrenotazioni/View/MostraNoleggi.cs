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
    public partial class MostraNoleggi : UserControl
    {
       
        public MostraNoleggi()
        {
            InitializeComponent();
           
        }

        public CheckBox isPerc
        {
            get
            {
                return checkBoxIsPercentuale;
            }
        }
        public TextBox Discount
        {
            get
            {
                return textBoxDiscount;
            }
        }
        public CheckBox isPagato
        {
            get
            {
                return checkBoxIsPagata;
            }
        }
        public ComboBox ComboFilitri
        {
            get
            {
                return comboBoxFilitri;
            }
        }

        public TextBox TextFiltri
        {
            get
            {
               return textBoxFilitri;
            }
        }
        public Button ApplicaFiltri
        {
            get
            {
                return buttonApplicaFilitri;
            }
        }
        public ListView ListaFilitri
        {
            get
            {
                return listViewFiltriApplicati;
            }
        }
        public Button ResetFilitri
        {
            get
            {
                return buttonClearFilitri;
            }
        }
        public Button ShowNolo
        {
            get
            {
                return buttonMostraDettagli;
            }
        }
        public Button RitornaMerce
        {
            get
            {
                return buttonRitorno;
            }
        }
        public DataGridView DataGridViewNolo
        {
            get
            {
                return dataGridViewRent;
            }
        }
    }
}
