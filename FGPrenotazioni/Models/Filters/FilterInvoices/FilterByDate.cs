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
    public class FilterByDate : FiltroBaseInvoices
    {
        private string _dateToFilter;
        private DateTime _dateToFilterDate;
        public FilterByDate(IFilterInvoices filtro,string dateToFilter): base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(dateToFilter))
                {
                    _dateToFilter = dateToFilter;
                    parseDate();
                }else
                    throw new ArgumentNullException("Filtro Date nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro date nullo" + e.StackTrace);
            }
        }

        protected override Func<Invoice, bool> Predicate
        {
            get
            {
                return Invoice => Invoice.EmissionDate.ToShortDateString().Equals(_dateToFilterDate.ToShortDateString());
            }
        }

        private void parseDate()
        {
            try
            {
                _dateToFilterDate = DateTime.Parse(_dateToFilter);
            }catch(Exception e)
            {
                MessageBox.Show("problemi nel parsing" + e.StackTrace);
            }
        }
      
    }
}
