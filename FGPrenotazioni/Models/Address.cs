using System;

namespace FGPrenotazioni.Models
{
    [Serializable]
    public class Address
    {
        private string _street;
        private string _civicNumber;
        private string _location;
        private string _CAP;
        private string _province;
        private string _nation;

        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
            }
        }

        public string CivicNumber
        {
            get
            {
                return _civicNumber;
            }

            set
            {
                _civicNumber = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public string CAP
        {
            get
            {
                return _CAP;
            }

            set
            {
                _CAP = value;
            }
        }

        public string Province
        {
            get
            {
                return _province;
            }

            set
            {
                _province = value;
            }
        }

        public string Nation
        {
            get
            {
                return _nation;
            }

            set
            {
                _nation = value;
            }
        }

        public Address(string _street, string _civicNumber, string _location, string _CAP, string _province, string _nation)
        {
            if(String.IsNullOrWhiteSpace(_street))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_civicNumber))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_location))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_province))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_nation))
                throw new ArgumentNullException();
            Street = _street;
            CivicNumber = _civicNumber;
            Location = _location;
            CAP = _CAP;
            Province = _province;
            Nation = _nation;
        }

        public string toFullString()
        {
            return Street + ", " + CivicNumber + " - " + Location + " CAP " + CAP + " (" + Province + ") - " + Nation;
        }
    }
}