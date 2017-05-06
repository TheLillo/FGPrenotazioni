using FGPrenotazioni.Models.Filters.FilterRent;
using FGPrenotazioni.Models.GoodsMovements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Filters.FilterRent
{
    public abstract class FiltroBaseRent : IFilterRent
    {
        private readonly IFilterRent _filtro;
        //pubblici perché devono essere raggiungibili dall'esterno
        public readonly static IFilterRent FiltroDiTutto = new _FiltroAll();
        public readonly static IFilterRent FiltroDiNiente = new _FiltroEmpty();

        protected abstract Func<Rent, bool> Predicate { get; }

        protected FiltroBaseRent(IFilterRent filtro)
        {
            //Controllo che filtro non sia nullo. In caso lo sia, _filtro = filtroTutto
            _filtro = filtro ?? FiltroDiTutto;
        }
        public IEnumerable<Rent> GetRent()
        {
            return _filtro.GetRent().Where(Predicate);
        }

        public class _FiltroAll : IFilterRent
        {
            public IEnumerable<Rent> GetRent()
            {
                return FGManager.Instance.RentsRiepilogue.GetAll;
            }
        }

        public class _FiltroEmpty : IFilterRent
        {
            public IEnumerable<Rent> GetRent()
            {
                return new List<Rent>();
            }
        }
    }
}
