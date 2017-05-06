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
    public class FilterByKind : FiltroBaseProdotti
    {
        private string _typeToFilter;

        public FilterByKind(IFilterProducts filtro,string _typeToFilter):base(filtro)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(_typeToFilter))
                    this._typeToFilter = _typeToFilter;
                else
                {
                    throw new ArgumentNullException("Type to filter null or empty");
                }
            }catch(Exception e)
            {
                MessageBox.Show("Filtro per tipo nullo" + e.StackTrace);
            }
          
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.GetKind().ToLower() == _typeToFilter.ToLower();
            }
        }

     
    }
}
