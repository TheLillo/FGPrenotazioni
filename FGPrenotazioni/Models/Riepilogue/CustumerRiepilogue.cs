using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Riepilogues
{
    public class CustomerRiepilogue : IRiepilogue<Customer>
    {

        private ObservableCollection<Customer> _customerList;

        public CustomerRiepilogue()
        {
            _customerList = new ObservableCollection<Customer>();
        }
        public ObservableCollection<Customer> GetAll
        {
            get
            {
                return _customerList;
            }
        }

        public void Add(Customer _toInsert)
        {
            _customerList.Add(_toInsert);
        }
        public void Remove(Customer _toRemove)
        {
            _customerList.Remove(_toRemove);
        }      
        public void AddAll(List<Customer> _toInsert)
        {
            foreach(Customer c in _toInsert)
            {
                _customerList.Add(c);
            }
        }
        /*public void Empty()
        {
            _costumerList.Clear();
        }*/
    }
}
