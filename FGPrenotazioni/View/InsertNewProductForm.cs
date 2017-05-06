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
    public partial class InsertNewProductForm : Form
    {
        

        public InsertNewProductForm()
        {
            InitializeComponent();
           
        }

        public ComboBox TipologiaCombo
        {
            get
            {
                return tipologyCombo;
            }
        }
        public ComboBox CategoryCombo
        {
            get
            {
                return categoryCombo;
            }
        }
        public TextBox DescrizioneText
        {
            get
            {
                return descrizioneText;
            }
        }
        public TextBox MarcaText
        {
            get
            {
                return marcaText;
            }
        }
        public TextBox VenditaText
        {
            get
            {
                return venditaText;
            }
        }
        public TextBox NoleggioText
        {
            get
            {
                return noleggioText;
            }
        }
        public Button ConfermaButton
        {
            get
            {
                return confermaButton;
            }
        }
        public Button BackButton
        {
            get
            {
                return backButton;
            }
        }






    }
}
