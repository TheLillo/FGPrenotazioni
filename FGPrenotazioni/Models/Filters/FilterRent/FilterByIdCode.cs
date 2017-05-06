using FGPrenotazioni.Models.Filters.FilterRent;
using FGPrenotazioni.Models.GoodsMovements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Models.Filters.FilterRent
{ 
    public class FilterByIdCode : FiltroBaseRent
    {
        private string _idCode;

        public FilterByIdCode(IFilterRent filtro, string idCode) : base(filtro)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(idCode))
                    _idCode = idCode;
                else
                    throw new ArgumentNullException();

            }
            catch (Exception e)
            {
                MessageBox.Show("filtro Codice Noleggio nullo" + e.StackTrace);
            }
        }

        protected override Func<Rent, bool> Predicate
        {
            get
            {
                return Rent => (Rent.Code.ToLower() == _idCode.ToLower());
            }
        }
    }
}
