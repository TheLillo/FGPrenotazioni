using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public interface IFilterCostumer
    {
        IEnumerable<Customer> GetCostumer();
    }
}
