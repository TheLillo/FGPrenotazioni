using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FGPrenotazioni.Models
{
    [Serializable]
    public abstract class Customer
    {
        private string _creditCard;
        private string _denomination;
        private string _phoneNumber;
        private string _eMail;
        private bool _reliable;
        private Address _address;

        public string CreditCard
        {
            get
            {
                return _creditCard;
            }
            set
            {
                _creditCard = value;
            }
        }

        public string Denomination
        {
            get
            {
                return _denomination;
            }

            set
            {
                _denomination = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }

        public string EMail
        {
            get
            {
                return _eMail;
            }

            set
            {
                _eMail = value;
            }
        }

        public bool Reliable
        {
            get
            {
                return _reliable;
            }

            set
            {
                _reliable = value;
            }
        }

        public Address Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public Customer(string _denomination,string _creditCard, string _phoneNumber, string _eMail, bool _reliable, Address _address)
        {
            if (String.IsNullOrWhiteSpace(_denomination))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_phoneNumber))
                throw new ArgumentNullException();
            if (_address == null)
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_creditCard))
                throw new ArgumentNullException();
            checkEmail(_eMail);
            Denomination = _denomination;
            PhoneNumber = _phoneNumber;
            CreditCard = _creditCard;
            EMail = _eMail;
            Reliable = _reliable;
            Address = _address;
        }
        private void checkEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Email is not valid");
            }

        }
        public abstract string Tipologia
        {
            get;
           
        }
        public abstract string toFullString();

        public abstract string ID { get; }
    }
}
