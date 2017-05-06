using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByCF : FiltroBaseCostumer
    {
        private string _cF;

        public FilterByCF(IFilterCostumer filtro, string cF) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(cF) || cF.Length == 16)
                    _cF = cF;
                else
                    throw new ArgumentNullException();

            }
            catch (Exception e)
            {
                MessageBox.Show("filtro Codice fiscale nullo" + e.StackTrace);
            }
        }

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Subject => (Subject is PrivateClient) && (Subject.ID.ToLower() == _cF.ToLower());
            }
        }
    }
}
