using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Invoices
{
    [Serializable]
    public abstract class Invoice
    {

        private readonly int _progressiveNumber;
        private DateTime _emissionDate;
        private double _amount;    
        private List<Product> _boughtProducts;
        private double _discount;
        private bool _toPay;
        private Customer _subject;
        private Employee _employee;

        public Invoice(int _progressiveNumber, bool _toPay, DateTime _emissionDate, double _amount, List<Product> _boughtProducts, double _discount, Customer _subject, Employee _employee)
        {
            if (_progressiveNumber == 0)
                throw new ArgumentNullException();
            if (_emissionDate == null)
                throw new ArgumentNullException();
            if (_boughtProducts == null)
                throw new ArgumentNullException();
            if (_subject == null)
                throw new ArgumentNullException();
            if (_employee == null)
                throw new ArgumentNullException();
            if (_amount < 0)
                throw new ArgumentNullException();
            this._toPay = _toPay;
            this._progressiveNumber = _progressiveNumber;
            this._emissionDate = _emissionDate;
            this._amount = _amount;
            this._boughtProducts = _boughtProducts;
            this._discount = _discount;
            this._subject = _subject;
            this._employee = _employee;
        }

        public int ProgressiveNumber
        {
            get
            {
                return _progressiveNumber;
            }
        }
        public bool ToPay
        {
            get
            {
                return _toPay;
            }
            set
            {
                _toPay = value;
            }
        }

        public DateTime EmissionDate
        {
            get
            {
                return _emissionDate;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
        }

        public List<Product> BoughtProducts
        {
            get
            {
                return _boughtProducts;
            }
        }

        public double Discount
        {
            get
            {
                return _discount;
            }
        }

        internal Customer Subject
        {
            get
            {
                return _subject;
            }
        }

        public string Employee
        {
            get
            {
                return _employee.Code;
            }
        }

        public abstract string toFullString();
    }
}
