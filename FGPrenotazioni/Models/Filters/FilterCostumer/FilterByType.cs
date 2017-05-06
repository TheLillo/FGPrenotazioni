using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByType : FiltroBaseCostumer
    {
        private string _typeToFind;

        public FilterByType(IFilterCostumer filtro, string typeToFind):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(typeToFind))
                    _typeToFind = typeToFind;
                else
                    throw new ArgumentNullException();
            }catch(Exception e)
            {
                MessageBox.Show("filtro type not found" + e.StackTrace);
            }
           
        }

        

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Subject => Subject.Tipologia.Equals(_typeToFind, StringComparison.CurrentCultureIgnoreCase);
            }
        }
    }
}
