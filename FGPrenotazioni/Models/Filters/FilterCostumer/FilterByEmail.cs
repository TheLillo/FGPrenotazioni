using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public class FilterByEmail: FiltroBaseCostumer
    {
        private MailAddress _eMail;


        public FilterByEmail(IFilterCostumer filtro, string eMail) : base(filtro)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(eMail))
                    _eMail = new MailAddress(eMail);
                else
                    throw new ArgumentNullException();
            }
            catch (Exception e)
            {
                MessageBox.Show("Filtro email nullo" + e.StackTrace);
            }
        }

        protected override Func<Customer, bool> Predicate
        {
            get
            {
                return Costumer => Costumer.EMail.Equals(_eMail);
            }
        }


    }
}
