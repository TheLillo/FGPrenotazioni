using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterProducts
{
    public class FilterByCategory : FiltroBaseProdotti
    {
        private string _categoryToFilter;
        
        public FilterByCategory(IFilterProducts filtro, string typeToFilter) :base(filtro)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(typeToFilter))
                {
                    _categoryToFilter = typeToFilter;
                   
                }
            }catch(Exception e)
            {
                MessageBox.Show("typeToFilter nullo oppure vuoto" + e.StackTrace);
            }
           
        }
        protected override Func<Product, bool> Predicate
        {

            get
            {
                return Product => Product.Category.ToLower()==_categoryToFilter.ToLower();
            }
        }

    }
}
