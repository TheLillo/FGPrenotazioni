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
    public class FilterBySellPrice : FiltroBaseProdotti
    {
        private string _sellPriceMax;
        private double _sellPriceMaxFloat;

        public FilterBySellPrice(IFilterProducts filtro, string sellPriceMax) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(sellPriceMax))
                {
                    _sellPriceMax = sellPriceMax;
                    try
                    {
                        _sellPriceMaxFloat = Double.Parse(_sellPriceMax);
                        _sellPriceMaxFloat = Models.Services.RoundToTwo(_sellPriceMaxFloat);
                    }
                    catch (InvalidProgramException e)
                    {
                        MessageBox.Show("Parse prezzoSell nullo" + e.StackTrace);
                    }
                }
                else
                    throw new ArgumentNullException("Filtro prezzoSell nullo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro prezzoSell nullo" + e.StackTrace);
            }
        }

        protected override Func<Product, bool> Predicate
        {
            get
            {
                return Product => Product.SellPrice <= _sellPriceMaxFloat;
            }
        }
    }
}
