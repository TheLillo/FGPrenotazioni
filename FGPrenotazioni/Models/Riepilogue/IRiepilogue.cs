using FGPrenotazioni.Models.Invoices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Riepilogues
{
    public interface IRiepilogue<T>
    {
        ObservableCollection<T> GetAll { get; }
       //void Empty();
       // void Remove(T _toRemove);
        void Add(T _toInsert);
        void AddAll(List<T> _toInsert);
    }
}
