using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.Filters.FilterInvoices;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FiltersInvoices
{
    public class FilterByEmployee : FiltroBaseInvoices
    {
        private string _employeeToFilterCode;

        public FilterByEmployee(IFilterInvoices filtro, string employeeToFilter ):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(employeeToFilter))
                    _employeeToFilterCode = employeeToFilter;
                else
                    throw new ArgumentNullException("Filtro Impiegati nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro Impiegati nullo" + e.StackTrace);
            }
        }

        protected override Func<Invoice, bool> Predicate
        {
            get
            {
                return Invoice => Invoice.Employee.ToLower() == _employeeToFilterCode.ToLower();
            }
        }
    }
}
