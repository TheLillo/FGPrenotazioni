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
    public class FilterByCode : FiltroBaseProdotti
    {
        private string _code;

        public FilterByCode(IFilterProducts filtro, string codeToFilter) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(codeToFilter))
                    _code = codeToFilter;
                else
                {
                    throw new ArgumentNullException("Type to filter null or empty");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro per codice nullo" + e.StackTrace);
            }

        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.ProductCode.ToLower() == _code.ToLower();
            }
        }


    }
}
