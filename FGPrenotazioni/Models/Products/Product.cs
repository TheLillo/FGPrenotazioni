using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace FGPrenotazioni.Models.Products
{
   
    [XmlInclude(typeof(AudioProduct))]
    [XmlInclude(typeof(LightProduct))]
    [XmlInclude(typeof(VideoProduct))]
    [Serializable]
    public abstract class Product
    {
        private string _productCode;
        private string _description;
        private double _sellPrice;
        private double _rentPrice;
        private bool _isNew;
        private bool _isAvailable;
        private string _brand;

        protected Product() { }

        public Product(string _productCode, string _description, double _sellPrice, double _rentPrice, bool _isNew, bool _isAvailable, string _brand)
        {
            if (String.IsNullOrEmpty(_productCode))
                throw new ArgumentNullException();
            if (String.IsNullOrEmpty(_description))
                throw new ArgumentNullException();
            if(String.IsNullOrWhiteSpace(_brand))
                throw new ArgumentNullException();
            this._productCode = _productCode;
            this._description = _description;
            this._sellPrice = _sellPrice;
            this._rentPrice = _rentPrice;
            this._isNew = _isNew;
            this._isAvailable = _isAvailable;
            this._brand = _brand;
        }
        public string ProductCode
        {
            get
            {
                return _productCode;
            }

            set
            {
                _productCode = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public double SellPrice
        {
            get
            {
                return _sellPrice;
            }

            set
            {
                _sellPrice = value;
            }
        }

        public double RentPrice
        {
            get
            {
                return _rentPrice;
            }

            set
            {
                _rentPrice = value;            }
        }

        public bool IsNew
        {
            get
            {
                return _isNew;
            }

            set
            {
                _isNew = value;            }
        }

        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }

            set
            {
                _isAvailable = value;            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                _brand = value;            }
        }

        public abstract string GetKind();

        public abstract string toFullString();

        public abstract string Category { get; set; }
           
       

    }
}