using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models
{
    [Serializable]
    public class Company : Customer
    {
        private string iD;

        public Company(string _denomination,string _creditCard , string _phoneNumber, string _eMail, bool _reliable, Address _address, string _pIVA) : base(_denomination, _creditCard, _phoneNumber, _eMail, _reliable, _address)
        {
            if (String.IsNullOrWhiteSpace(_pIVA) || _pIVA.Length!=11)
                throw new ArgumentNullException();
            iD = _pIVA;
        }

        public override string ID
        {
            get
            {
                return iD;
            }
        }

        public override string Tipologia
        {
            get
            {
                return "Company";
            }
        }
 

        public override string toFullString()
        {
            return Denomination + "; cc " + CreditCard + "; phone " + PhoneNumber + "; email " + EMail + "; reliable = " + Reliable.ToString() + "; " + Address.toFullString() + "; p.iva = " + ID;
        }
    }
}
