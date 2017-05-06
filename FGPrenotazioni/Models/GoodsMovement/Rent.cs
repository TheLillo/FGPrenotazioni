using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.GoodsMovements
{
    [Serializable]
    public class Rent : GoodsMovement
    {
        private DateTime _beginDate;
        private DateTime _endDate;
        private Customer _customer;
        private string _code;

        public string Code
        {
            get
            {
                return _code;
            }
        }

        public DateTime BeginDate
        {
            get
            {
                return _beginDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
        }
        public string Custumer
        {
            get
            {
                return _customer.ID;
            }
        }


        public Rent(List<Product> _productsToMove, DateTime _beginDate, DateTime _endDate, string _code,Customer _custumer) : base(_productsToMove)
        {
            if(_beginDate == null)
                throw new ArgumentNullException("Nessuna data di inizio noleggio");
            if(_endDate == null)
                throw new ArgumentNullException("Nessuna data di fine noleggio");
            if (String.IsNullOrWhiteSpace(_code))
                throw new ArgumentNullException("Nessun codice noleggio presente");
            if (_custumer == null)
            {
                throw new ArgumentNullException();
            }
            this._beginDate = _beginDate;
            this._endDate= _endDate;
            this._customer = _custumer;
            this._code = _code;
        }

        public override string toFullString()
        {
            StringBuilder _sb = new StringBuilder();

            _sb.Append(BeginDate.ToShortDateString());
            _sb.Append(" begin - ");
            _sb.Append(EndDate.ToShortDateString());
            _sb.Append(" end; ");
            _sb.Append(Code);
            _sb.Append(Environment.NewLine);
            _sb.Append(_customer.ID);
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
