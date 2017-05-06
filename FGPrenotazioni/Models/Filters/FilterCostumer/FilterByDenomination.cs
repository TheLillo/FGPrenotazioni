using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByDenomination : FiltroBaseCostumer
    {
        private string _denomination;

                
        public FilterByDenomination(IFilterCostumer filtro, string denomination):base(filtro)
        {
           try
            {
                if (!String.IsNullOrWhiteSpace(denomination))
                    _denomination = denomination;
                else
                    throw new ArgumentNullException();
            }catch(Exception e)
            {
                MessageBox.Show("Filtro denominazione nullo" + e.StackTrace);
            }
        }

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Subject => Subject.Denomination.Equals(_denomination, StringComparison.CurrentCultureIgnoreCase);
            }
        }

       
    }
}
