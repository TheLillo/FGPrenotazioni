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
    public class FilterByIdSubject : FiltroBaseInvoices
    {
        private string _subjectToFilter;

        public FilterByIdSubject(IFilterInvoices filtro, string subjectToFilter) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(subjectToFilter))
                {
                    if (subjectToFilter.Length == 16 || subjectToFilter.Length == 11)
                        _subjectToFilter = subjectToFilter;
                    else
                        throw new InvalidProgramException();
                }
                else
                    throw new ArgumentNullException();
            }
            catch (Exception e)
            {
                MessageBox.Show("filtro subject nullo oppure valori non validi " + e.StackTrace);
            }
        }

        protected override Func<Invoice, bool> Predicate
        {
            get
            {
                if (_subjectToFilter.Length == 16)
                {
                    return Invoice => Invoice.Subject.ID == _subjectToFilter;
                }
                return Invoice => _subjectToFilter.Length == 11 && Invoice.Subject.ID == _subjectToFilter;
            }

        }
      
    
    }
}
