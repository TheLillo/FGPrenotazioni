using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Invoices;
using System.Collections.ObjectModel;

namespace FGPrenotazioni.Models.Riepilogues
{
    public class InvoicesRiepilogue : IRiepilogue<Invoice>
    {
        private ObservableCollection<Invoice> _invoicesList;

        public InvoicesRiepilogue()
        {
            _invoicesList = new ObservableCollection<Invoice>();
        }
        public ObservableCollection<Invoice> GetAll
        {
            get
            {
                return _invoicesList;
            }
        }
        public void Add(Invoice _toInsert)
        {
            _invoicesList.Add(_toInsert);
        }

        public void AddAll(List<Invoice> _toInsert)
        {
            foreach (Invoice i in _toInsert)
            {
                _invoicesList.Add(i);
            }
        }
       /* public void Empty()
        {
            _invoicesList.Clear();
        }*/

    }
}
