using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Invoices
{
    [Serializable]

    public class SellInvoice : Invoice
    {
        public SellInvoice(int _progressiveNumber,bool _toPay, DateTime _emissionDate, double _amount, List<Product> _boughtProducts, double _discount, Customer _subject, Employee _empoloyee) : base(_progressiveNumber, _toPay,_emissionDate, _amount, _boughtProducts, _discount, _subject, _empoloyee)
        {
        }

        public override string toFullString()
        {
            StringBuilder _sb = new StringBuilder();

            _sb.Append("SELL ");
            _sb.Append(ProgressiveNumber);
            _sb.Append("; toPay = ");
            _sb.Append(ToPay.ToString());
            _sb.Append("; em.date ");
            _sb.Append(EmissionDate.ToShortDateString());
            _sb.Append("; ");
            _sb.Append(Amount);
            _sb.Append("€ amount " + Environment.NewLine);
            foreach (Product _pr in BoughtProducts)
            {
                _sb.Append(_pr.toFullString());
                _sb.Append(Environment.NewLine);
            }
            _sb.Append(Discount);
            _sb.Append("€ discount; " + Environment.NewLine);
            _sb.Append(Subject.toFullString());
            _sb.Append(Environment.NewLine);
            _sb.Append(Employee + Environment.NewLine);

            return _sb.ToString();
        }
    }
}
