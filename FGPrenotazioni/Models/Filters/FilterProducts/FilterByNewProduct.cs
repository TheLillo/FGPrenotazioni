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
    /*
     * ATTRIBUTES == ISNEW? True == prodotto nuovo , False == prodotto usato 
     */

    public class FilterByNewProduct : FiltroBaseProdotti
    {
        private string _attributesToFind;


        public FilterByNewProduct(IFilterProducts filtro,string attributes):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(attributes))
                    _attributesToFind = attributes;
                else
                    throw new ArgumentNullException("Filtro attributes nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro attributes nullo"+e.StackTrace);
            }
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.IsNew.ToString().ToLower() == _attributesToFind.ToLower();
            }
        }
    }
}
