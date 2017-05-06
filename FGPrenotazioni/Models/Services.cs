using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.GoodsMovements;
using FGPrenotazioni.Models.Products;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.Riepilogues;

namespace FGPrenotazioni.Models
{
    public static class Services
    {
        public static double CalculateFee(DateTime _dateNow, Rent _thisRent)
        {
            DateTime _endDate = _thisRent.EndDate;
            TimeSpan difference = _dateNow.Subtract(_thisRent.EndDate);
            if (difference.TotalDays <= 0)
            {
                return 0;
            }
            else
            {
                if (difference.TotalDays >= 30)
                {
                    return difference.TotalDays * 20 + 100;
                }
                else
                    return difference.TotalDays * 20;
            }
        }

        public static double CalculateDiscountPerc(double _perc, double _amount)
        {
            if (_perc >= 0 && _perc <= 100)
            {
                decimal _totalAfterDiscount;
                decimal _newAmount = new decimal(_amount);
                decimal calculateDisc;
                decimal discount = new decimal(_perc);
                calculateDisc = discount / 100;
                _totalAfterDiscount = calculateDisc * _newAmount;
                return RoundToTwo(decimal.ToDouble(_totalAfterDiscount));
            }
            else
                throw new ArgumentException("inserisci una percentuale valida :)");
        }

        public static double RoundToTwo(double _toRound)
        {
            decimal dec = new decimal(_toRound);
            return decimal.ToDouble(Math.Round(dec, 2));
        }

        public static double CalculateAmount(GoodsMovement _movement)
        {
            double _amount = 0;

            if (_movement is Rent)
            {
                Rent temp = (Rent)_movement;
                foreach (Product _product in _movement.ProductsToMove)
                {
                    _amount+= _product.RentPrice * (temp.EndDate - temp.BeginDate).Days;
                }
            }
            else if (_movement is Sell)
            {
                foreach (Product _product in _movement.ProductsToMove) _amount += _product.SellPrice;
            }

            return RoundToTwo(_amount);
        }

        public static double CalculateAmountWithDiscount(double _amount, double _discount)
        {
            if (_discount >= _amount)
                throw new ArgumentOutOfRangeException();
            else
                return _amount - _discount;
        }

        public static string CalculateProductCode(string type,string brand,long  progressiveProductNumber)
        {
            string stringProductNumber = progressiveProductNumber.ToString("D5");

            if (stringProductNumber.Length != 5)
            {
               throw new ArgumentException();
            }
            else  return (type.Substring(0, 1) + brand.Substring(0, 2) + stringProductNumber).ToUpper();
        }

        public static string CalculateRentCode()
        {
            long code = 0;

            if (FGManager.Instance.RentsRiepilogue.GetAll.Count == 0)
                return ++code + "";
            else
            {
                long lastCode = long.Parse(FGManager.Instance.RentsRiepilogue.GetAll.Last().Code);
                return ++lastCode + "";
            }
              
        }
    }
}
