using FGPrenotazioni.Models.GoodsMovements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Filters.FilterRent
{
    public interface IFilterRent
    {
        IEnumerable<Rent> GetRent();
    }
}
