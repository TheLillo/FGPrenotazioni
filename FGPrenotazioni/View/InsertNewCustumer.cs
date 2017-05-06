using FGPrenotazioni.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.View
{
    public partial class InsertNewCustumer : Form
    {
     
        public InsertNewCustumer()
        {
            InitializeComponent();
           
        }
        public Button Conferma
        {
            get
            {
                return buttonConferma;
            }
        }
        public Button Indietro
        {
            get
            {
                return buttonIndietro;
            }
        }
        public RadioButton Company
        {
            get
            {
                return company;
            }
        }
        public RadioButton PrivateSubject
        {
            get
            {
                return privateSubject;
            }            
        }
        public TextBox NumberCell
        {
            get
            {
                return textBoxCellNumber;
            }
        }
        public TextBox CreditCard
        {
            get
            {
                return textBoxCreditCard;
            }
        }
        public TextBox Email
        {
            get
            {
                return textBoxEmail;
            }
        }

        public TextBox Denomination
        {
            get
            {
                return textBoxDenominazione;
            }
        }
        public TextBox Street
        {
            get
            {
                return textBoxVia;
            }
        }
        public TextBox NumeroCivico
        {
            get
            {
                return textBoxNumeroCivico;
            }
        }
        public TextBox City
        {
            get
            {
                return textBoxCity;
            }
        }
        public TextBox CAP
        {
            get
            {
                return textBoxCap;
            }
        }
        public TextBox Province
        {
            get
            {
                return textBoxProvincia;
            }
        }
        public TextBox Nazione
        {
            get
            {
                return textBoxNazione;
            }
        }
        public TextBox ID
        {
            get
            {
                return textBoxID;
            }
        }

    }
}
