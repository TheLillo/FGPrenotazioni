using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FGPrenotazioni.Models.Filters.FilterProducts
{
    public class FilterByRentPrice: FiltroBaseProdotti
    {
        private string _rentPriceMax;
        private double _rentPriceMaxFloat;

        public FilterByRentPrice(IFilterProducts filtro, string rentPriceMax) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(rentPriceMax))
                {
                    _rentPriceMax = rentPriceMax;
                    try
                    {
                        _rentPriceMaxFloat = Double.Parse(_rentPriceMax);
                        _rentPriceMaxFloat = Models.Services.RoundToTwo(_rentPriceMaxFloat);
                    }
                    catch (InvalidProgramException e)
                    {
                        MessageBox.Show("Parse prezzoRent nullo" + e.StackTrace);
                    }
                }
                else
                    throw new ArgumentNullException("Filtro prezzoRent nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro prezzoRent nullo" + e.StackTrace);
            }
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.RentPrice <= _rentPriceMaxFloat;
            }
        }
    }
}
