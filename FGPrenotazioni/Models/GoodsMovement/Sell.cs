using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.GoodsMovements
{
    public class Sell : GoodsMovement
    {
        private DateTime _date;

        public Sell(List<Product> _productsToMove, DateTime _date) : base(_productsToMove)
        {
            if (_date == null)
                throw new ArgumentNullException("Nessuna data di vendita presente");
            this._date = _date;
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public override string toFullString()
        {
            StringBuilder _sb = new StringBuilder();

            _sb.Append(Date.ToShortDateString());
            _sb.Append(Environment.NewLine);
            foreach (Product _product in ProductsToMove)
            {
                _sb.Append(_product.toFullString());
                _sb.Append(Environment.NewLine);
            }

            return _sb.ToString();
        }
    }
}
