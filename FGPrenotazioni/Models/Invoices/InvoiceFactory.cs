using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.GoodsMovements;
using FGPrenotazioni.Models;
using static FGPrenotazioni.Models.FGManager;

namespace FGPrenotazioni.Models.Invoices
{
    public  static class InvoiceFactory
    {
        
        private static int _progressiveNumber;


        public static int ProgressiveNumber
        {
            get
            {
                return _progressiveNumber;
            }
            set
            {
                _progressiveNumber = value;
            }
           
        }

        private static DateTime EmissionDate
        {
            get
            {
                return DateTime.Now;
            }
        }
       
        private static double CalcFee(Rent _thisRent)
        {
            double _fee = Services.CalculateFee(EmissionDate,_thisRent);
            if (_fee >= 0)
                return Services.RoundToTwo(_fee);
            else
                return 0.0;
        }


        public static Invoice CreateInvoice(int _progressiveNumber, bool _toPay, double _amount, double _discount, Customer _subject, Employee _employee,GoodsMovement _goodMovement)
        {
            if (_goodMovement is Rent)
                return new RentInvoice(_progressiveNumber, _toPay, EmissionDate, _amount + CalcFee((Rent)_goodMovement), _goodMovement.ProductsToMove, _discount, _subject, _employee, CalcFee((Rent)_goodMovement));
            else
            {
                if (_goodMovement is Sell)
                    return new SellInvoice(_progressiveNumber, _toPay, EmissionDate, _amount, _goodMovement.ProductsToMove, _discount, _subject, _employee);
                else
                    return null;
            }
        }
    }
}
