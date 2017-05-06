using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models
{
    [Serializable]
    public class PrivateClient : Customer
    {
        private string iD;

        public PrivateClient(string _denomination,string _creditCard, string _phoneNumber, string _eMail, bool _reliable, Address _address, string _fiscalCode) : base(_denomination, _creditCard, _phoneNumber, _eMail, _reliable, _address)
        {
            if (String.IsNullOrWhiteSpace(_fiscalCode) || _fiscalCode.Length!=16)
                throw new ArgumentNullException("Codice Fiscale non valido");
            iD = _fiscalCode;   
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
                return "Private";
            }
        }
       

        public override string toFullString()
        {
            return Denomination + "; cc " + CreditCard + "; phone " + PhoneNumber + "; email " + EMail + "; reliable = " + Reliable.ToString() + "; " + Address.toFullString() + "; fiscalcode = " + ID;
        }
    }
}
