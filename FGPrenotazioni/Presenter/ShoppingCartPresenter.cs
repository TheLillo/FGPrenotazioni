using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.GoodsMovements;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.Products;

namespace FGPrenotazioni.Presenter
{
    class ShoppingCartPresenter : Presenter
    {
        public ShopppingCartForm View
        {
            get
            {
                return (ShopppingCartForm)Element;
            }
        }

        public ShoppingCartPresenter(ShopppingCartForm view):base(view)
        {
            populateView();
            View.ConfermaButton.Click += OnConfermaClick;
            View.NascondiButton.Click += OnIndietroClick;
            View.EliminaProdotto.Click += OnDeleteProduct;
            FGManager.Instance.ShoppingCart.ProductsList.CollectionChanged += onPropertyChanged;
        }

        public void onPropertyChanged(object sender,EventArgs e)
        {
            populateView();
        }
        private void populateView()
        {
            if (FGManager.Instance.ShoppingCart.ProductsList.ToList().Count > 0)
            {
                View.ShoppingCartDataGrid.DataSource = null;
                View.ShoppingCartDataGrid.Rows.Clear();
                View.ShoppingCartDataGrid.DataSource = FGManager.Instance.ShoppingCart.ProductsList.ToList();
            }else
            {
                GestoreView.GetInstance().ChiudiView(typeof(ShopppingCartForm));
            }
        }
       

        public void OnIndietroClick(object sender, EventArgs e)
        {
            GestoreView.GetInstance().ChiudiView(typeof(ShopppingCartForm));
        }

        public void OnConfermaClick(object sender, EventArgs e)
        {
            if (FGManager.Instance.ShoppingCart.ProductsList.Count > 0)
            {
                bool isVendita = true;
                if (View.Vendita.Checked)
                {
                    isVendita = true;
                }
                else if (View.Noleggio.Checked)
                {
                    isVendita = false;
                }

                if (isVendita) //fai partire gestore view per la venditaForm
                {
                    GestoreView.GetInstance().MostraView(typeof(MostraSubAfterShoppingVendita),typeof(MostraSubjectFromShoppingPresenterVendita));
                    GestoreView.GetInstance().ChiudiView(typeof(ShopppingCartForm));
                    GestoreView.GetInstance().NascondiView(typeof(MainPage));

                }
                else //gestore view NoleggioForm
                {
                    GestoreView.GetInstance().MostraView(typeof(MostraSubAfterShoppingNolo),typeof(MostraSubjectFromShoppingNoloPresenter));
                    GestoreView.GetInstance().ChiudiView(typeof(ShopppingCartForm));
                    GestoreView.GetInstance().NascondiView(typeof(MainPage));
                }
            }else
            {
                MessageBox.Show("Carrello Vuoto non puoi procedere");
            }
        }


        public void OnDeleteProduct(object sender, EventArgs e)
        {
            if (FGManager.Instance.ShoppingCart.ProductsList.Count != 0)
            {
                Product selected = View.ShoppingCartDataGrid.CurrentRow.DataBoundItem as Product;
                FGManager.Instance.Warehouse.ProductList.Where(p => p.ProductCode == selected.ProductCode).First().IsAvailable = true;
                FGManager.Instance.ShoppingCart.RemoveProduct(selected);
                populateView();
            }
            else MessageBox.Show("Carrello vuoto!", "SHOPPING CART", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
