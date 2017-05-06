using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Invoices;
using System.Windows.Forms;
using FGPrenotazioni.Models.Filters.FilterInvoices;

namespace FGPrenotazioni.Models.Filters.FiltersInvoices
{
    public class FilterByProgressiveNumber : FiltroBaseInvoices
    {
        private string _numberToFilter;
        private int _progressiveNumber;
        public FilterByProgressiveNumber(IFilterInvoices filtro, string number):base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(number))
                {
                    this._numberToFilter = number;
                    ParseNumber();
                }
                else
                    throw new ArgumentNullException("Numero progressvio nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("numberProgressive nullo " + e.StackTrace);
            }
          
        }

        protected override Func<Invoice, bool> Predicate
        {
            get
            {
                return Invoice => Invoice.ProgressiveNumber == _progressiveNumber;
            }
        }

        private void ParseNumber()
        {
            try
            {
                _progressiveNumber = Int32.Parse(_numberToFilter);
            }catch(Exception e)
            {
                MessageBox.Show("Errore nel parsing progressive number"+e.StackTrace);
            }
        }
    }
}
