using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.Presenter;

namespace FGPrenotazioni.View
{
    public partial class MostraSubAfterShoppingVendita : Form
    {
        public MostraSubAfterShoppingVendita()
        {
            InitializeComponent();
           
        }

        public MostraSubject MostraSubject
        {
            get
            {
                return mostraSubjectShopping;
            }
        }
   
        public Button ProcediVendita
        {
            get
            {
              return  procediButton;
            }
        }
        public TextBox Sconto
        {
            get
            {
                return scontoBox;
            }
        }
        public CheckBox Pagato
        {
            get
            {
                return pagatoCheckBox;
            }
        }
        public CheckBox ScontoPercentuale
        {
            get
            {
                return isPercCheckBox;
            }
        }
        public Button InditetroButton
        {
            get
            {
                return indietroButton;
            }
        }

        public Label TotaleLabel
        {
            get
            {
                return totaleLabel;
            }
        }
    }
}
