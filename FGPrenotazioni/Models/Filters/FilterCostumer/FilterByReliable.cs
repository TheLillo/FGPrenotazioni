using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByReliable : FiltroBaseCostumer
    {
        private string _reliable;

        public FilterByReliable(IFilterCostumer filtro,string realiable):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(realiable))
                {
                    _reliable = realiable;
                }
                else
                    throw new ArgumentNullException();
            }catch(Exception e)
            {
                MessageBox.Show("Disponibilità nulla" + e.StackTrace);
            }  
        }

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Subject => Subject.Reliable.ToString().ToLower() == _reliable.ToLower();
            }
        }


    }
}
