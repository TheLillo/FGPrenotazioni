using FGPrenotazioni.Models.Filters.FilterCostumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Filters.FilterCostumer
{
    public abstract class FiltroBaseCostumer : IFilterCostumer
    {
        private readonly IFilterCostumer _filtro;
        //pubblici perché devono essere raggiungibili dall'esterno
        public readonly static IFilterCostumer FiltroDiTutto = new _FiltroAll();
        public readonly static IFilterCostumer FiltroDiNiente = new _FiltroEmpty();

        protected abstract Func<Customer, bool> Predicate { get; }

        protected FiltroBaseCostumer(IFilterCostumer filtro)
        {
            //Controllo che filtro non sia nullo. In caso lo sia, _filtro = filtroTutto
            _filtro = filtro ?? FiltroDiTutto;
        }
        public IEnumerable<Customer> GetCostumer()
        {
            return _filtro.GetCostumer().Where(Predicate);
        }

        public class _FiltroAll : IFilterCostumer
        {
            public IEnumerable<Customer> GetCostumer()
            {
                return FGManager.Instance.CostumerRiepilogue.GetAll;
            }
        }

        public class _FiltroEmpty : IFilterCostumer
        {
            public IEnumerable<Customer> GetCostumer()
            {
                return new List<Customer>();
            }
        }
    }
}
