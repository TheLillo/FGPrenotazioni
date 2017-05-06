using FGPrenotazioni.Models.Filters.FiltersInvoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Invoices;

namespace FGPrenotazioni.Models.Filters.FilterInvoices
{
    public abstract class FiltroBaseInvoices : IFilterInvoices
    {
        private readonly IFilterInvoices _filtro;
        //pubblici perché devono essere raggiungibili dall'esterno
        public readonly static IFilterInvoices FiltroDiTutto = new _FiltroAll();
        public readonly static IFilterInvoices FiltroDiNiente = new _FiltroEmpty();

        protected abstract Func<Invoice, bool> Predicate { get; }

         protected FiltroBaseInvoices(IFilterInvoices filtro)
        {
            //Controllo che filtro non sia nullo. In caso lo sia, _filtro = filtroTutto
            _filtro = filtro ?? FiltroDiTutto;
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return _filtro.GetInvoices().Where(Predicate);
        }

        public class _FiltroAll : IFilterInvoices
        {
          //  restituisce tutte invoices  Disponibili
            public IEnumerable<Invoice> GetInvoices()
            {

               return FGManager.Instance.InvoicesRiepilogue.GetAll;
            }
        }

        public class _FiltroEmpty : IFilterInvoices
        {
            // restituisce una lista vuota
            public IEnumerable<Invoice> GetInvoices()
            {
                return new List<Invoice>();
            }
        }
    }
}
