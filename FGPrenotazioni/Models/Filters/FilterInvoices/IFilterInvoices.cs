using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Invoices;

namespace FGPrenotazioni.Models.Filters.FiltersInvoices
{
    public interface IFilterInvoices
    {
        IEnumerable<Invoice> GetInvoices();
    }
}