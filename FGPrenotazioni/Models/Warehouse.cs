using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace FGPrenotazioni.Models
{
    public class Warehouse
    {
        private ObservableCollection<Product> _productList;
        
        public Warehouse()
        {
            _productList = new ObservableCollection<Product>();
        }
        public ObservableCollection<Product> ProductList
        {
            get
            {
                return _productList;
            }
        }

        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }

        public void RemoveProduct(Product selected)
        {
            _productList.Remove(selected);
        }
    }
}
