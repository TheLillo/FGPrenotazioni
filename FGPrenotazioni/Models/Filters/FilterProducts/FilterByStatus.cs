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
    * STATUS == ISAVAILABLE? True == prodotto disponibile , False == prodotto non disponibile (già noleggiato)
    */

    public class FilterByStatus : FiltroBaseProdotti
    {
        private string _statusToFind;

        public FilterByStatus(IFilterProducts filtro, string statusToFind) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(statusToFind))
                   _statusToFind = statusToFind;
                else
                    throw new ArgumentNullException("Filtro status nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro status nullo" + e.StackTrace);
            }
           
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.IsAvailable.ToString().ToLower() == _statusToFind.ToLower();
            }
        }
    }
}
