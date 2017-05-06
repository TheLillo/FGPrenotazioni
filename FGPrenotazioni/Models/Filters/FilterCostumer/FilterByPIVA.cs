using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByPIVA :FiltroBaseCostumer
    {
        private string _pIva;

        public FilterByPIVA(IFilterCostumer filtro, string pIva):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(pIva) || pIva.Length==11)
                    _pIva = pIva;
                else
                    throw new ArgumentNullException();

            }catch(Exception e)
            {
                MessageBox.Show("filtro partita iva nullo" + e.StackTrace);
            }
        }

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Costumer => (Costumer is Company) && (Costumer.ID.ToLower() == _pIva.ToLower());
            }
        }
    }
}
