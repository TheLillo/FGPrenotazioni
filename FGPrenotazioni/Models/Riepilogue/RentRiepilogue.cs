using FGPrenotazioni.Models.GoodsMovements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Riepilogues
{
    public class RentRiepilogue : IRiepilogue<Rent>
    {
        private ObservableCollection<Rent> _rentList;


        public RentRiepilogue()
        {
            _rentList = new ObservableCollection<Rent>();
        }
        public ObservableCollection<Rent> GetAll
        {
            get
            {
                return _rentList;
            }
        }

        public void Add(Rent _toInsert)
        {
            _rentList.Add(_toInsert);
        }
        
        public void Remove(Rent _toRemove)
        {
            _rentList.Remove(_toRemove);
        }

        public void AddAll(List<Rent> _toInsert)
        {
            foreach(Rent r in _toInsert)
            {
                _rentList.Add(r);
            }
        }
       /* public void Empty()
        {
            _rentList.Clear();
        }*/
    }
}
