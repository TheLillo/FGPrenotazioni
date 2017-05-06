using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterProducts
{
    public class FilterByBrand : FiltroBaseProdotti
    {
        private string _brandToFilter;

        public FilterByBrand(IFilterProducts filtro ,string _brandToFilter):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(_brandToFilter))
                    this._brandToFilter = _brandToFilter;
                else
                    throw new ArgumentNullException("Brand To Filter empty or null");
            }catch(Exception e)
            {
                MessageBox.Show("Filtro Brand nullo" + e.StackTrace);
            }
            
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.Brand.ToLower() == _brandToFilter.ToLower();
            }
        }

      
    }
}
