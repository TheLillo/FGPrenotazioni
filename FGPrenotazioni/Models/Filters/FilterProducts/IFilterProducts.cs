using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Filters.FilterProducts
{
    public interface IFilterProducts
    {
        IEnumerable<Product> GetProdotti();
    }
}
