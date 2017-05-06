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
    public class FilterDateMore : FiltroBaseInvoices
    {
        private string _dateToFilter;
        private DateTime _dateToFilterDate;
        public FilterDateMore(IFilterInvoices filtro, string date):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(date))
                {
                    _dateToFilter = date;
                    parseDate();
                }
                else
                    throw new ArgumentNullException();
                  
            }catch(Exception e)
            {
                MessageBox.Show("Date filtro nulla "+e.StackTrace);
            }
        }

        protected override Func<Invoice, bool> Predicate
        {
            get
            {
                return Invoice => Invoice.EmissionDate >= _dateToFilterDate;
            }
        }
        private void parseDate()
        {
            try
            {
                _dateToFilterDate = DateTime.Parse(_dateToFilter);
            }
            catch (Exception e)
            {
                MessageBox.Show("problemi nel parsing" + e.StackTrace);
            }
        }

    }
}