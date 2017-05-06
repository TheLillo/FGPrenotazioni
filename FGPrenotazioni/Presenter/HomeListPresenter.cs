using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models.Products;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.GoodsMovements;

namespace FGPrenotazioni.Presenter
{
    class HomeListPresenter : Presenter
    {
        public HomeList View
        {
            get { return (HomeList) Element; }
        }

        public HomeListPresenter(HomeList view) : base(view)
        {
            PopulateWarehouseGrid();
            View.AddButton.Click += onAddClick;
            View.RemoveButton.Click += onRemoveClick;
            FGManager.Instance.Warehouse.ProductList.CollectionChanged += onAddedProduct;
        }

        private void PopulateWarehouseGrid()
        {
            View.WarehouseDataGrid.DataSource = null;
            View.WarehouseDataGrid.Rows.Clear();
            View.WarehouseDataGrid.DataSource = FGManager.Instance.Warehouse.ProductList;

        }

        private void onAddedProduct(object sender, EventArgs args)
        {
            PopulateWarehouseGrid();
        }

        private void onAddClick(object sender, EventArgs args)
        {
            GestoreView.GetInstance().MostraView(typeof(InsertNewProductForm), typeof(InsertNewProductPresenter));
            GestoreView.GetInstance().NascondiView(typeof(MainPage));
        }
        private void onRemoveClick(object sender, EventArgs args)
        {
            if (FGManager.Instance.Warehouse.ProductList.Count != 0)
            {
                bool trovato = false;
                Product selected = (Product)View.WarehouseDataGrid.CurrentRow.DataBoundItem;
                foreach(Rent r in FGManager.Instance.RentsRiepilogue.GetAll)
                {

                    foreach(Product p in r.ProductsToMove)
                    {
                        if(p.ProductCode==selected.ProductCode)
                        {
                            MessageBox.Show("Questo prodotto è collegato a un noleggio attivo. Impossibile rimuoverlo");
                            trovato = true;
                        }
                    }                                                
                }

                if (!trovato)
                {
                    FGManager.Instance.Warehouse.RemoveProduct(selected);
                    PopulateWarehouseGrid();
                }
            }
            else MessageBox.Show("Magazzino vuoto!", "WAREHOUSE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
