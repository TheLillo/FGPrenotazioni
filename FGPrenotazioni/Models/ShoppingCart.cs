using FGPrenotazioni.Models.Products;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models
{
    public class ShoppingCart
    {
        private ObservableCollection<Product>  _productsList;

        public ObservableCollection<Product> ProductsList
        {
            get
            {
                return _productsList;
            }
        }
        public ShoppingCart()
        {
            _productsList = new ObservableCollection<Product>();
        }
        public void AddProduct(Product _product)
        {
            _productsList.Add(_product);
        }
        public void EmptyShoppingCart()
        {
            _productsList.Clear();
        }
        public void RemoveProduct(Product _product)
        {
            _productsList.Remove(_product);
        }

    }
}
