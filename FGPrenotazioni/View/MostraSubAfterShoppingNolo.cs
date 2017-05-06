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
    public partial class MostraSubAfterShoppingNolo : Form
    {
        
        public MostraSubAfterShoppingNolo()
        {
            InitializeComponent();
           
        }

        public MostraSubject MostraSubject
        {
            get
            {
                return mostraSubject1;
            }
        }

        public DateTimePicker InizioTime
        {
            get
            {
                return inizioTime;
            }
        }

        public DateTimePicker FineTime
        {
            get
            {
                return fineTime;
            }
        }

        public Label TotaleLabel
        {
            get
            {
                return totaleLabel;
            }
        }

        public TextBox ScontoTextBox
        {
            get
            {
                return scontoTextBox;
            }
        }

        public CheckBox IsPercentuale
        {
            get
            {
                return isPercentuale;
            }
        }
        public Button ProcediButton
        {
            get
            {
                return procediButton;
            }
        }
        public Button IndietroButton
        {
            get
            {
                return indietroButton;
            }
        }
    }
}
