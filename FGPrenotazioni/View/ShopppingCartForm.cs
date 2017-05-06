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
    public partial class ShopppingCartForm : Form
    {
        public ShopppingCartForm()
        {
            InitializeComponent();

        }
        public Button NascondiButton
        {
            get
            {
                return indietroButton;
            }
        } 
        public Button ConfermaButton
        {
            get
            {
                return procediButton;
            }
        }
        public DataGridView ShoppingCartDataGrid
        {
            get
            {
                return shoppingCartDataGridView;
            }
        }
        public RadioButton Vendita
        {
            get
            {
                return venditaRadioButton;
            }
        }
        public RadioButton Noleggio
        {
            get
            {
                return noleggioRadioButton;
            }
        }
        public Button EliminaProdotto
        {
            get
            {
                return eliminaProductShopping;
            }
        }
    }
}
