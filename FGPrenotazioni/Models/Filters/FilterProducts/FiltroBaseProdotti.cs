using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Products;

namespace FGPrenotazioni.Models.Filters.FilterProducts
{
    public abstract class FiltroBaseProdotti : IFilterProducts
    {
        private readonly IFilterProducts _filtro;
        //pubblici perché devono essere raggiungibili dall'esterno
        public readonly static IFilterProducts FiltroDiTutto = new _FiltroAll();
        public readonly static IFilterProducts FiltroDiNiente = new _FiltroEmpty();

        protected abstract Func<Product, bool> Predicate { get; }

        protected FiltroBaseProdotti(IFilterProducts filtro)
        {
            //Controllo che filtro non sia nullo. In caso lo sia, _filtro = filtroTutto
            _filtro = filtro ?? FiltroDiTutto;
        }
        public IEnumerable<Product> GetProdotti()
        {
            /*
              Richiama il metodo GetProdotti del filtro passato quando è stato invocato il costruttore
              Where è un metodo predefinito di IEnumerable in grado di restituire il risultato del
              filtraggio di una sequenza di valori in base ad un predicato passato in ingresso.
              Il predicato deve essere un delegato generico Func<TSource,bool>, dove TSource è il tipo
              della sorgente in ingresso
          */
            return _filtro.GetProdotti().Where(Predicate);
        }

        private class _FiltroAll : IFilterProducts
        {
            //Filtro che non filtra: restituisce tutti i Prodotti Disponibili
            public IEnumerable<Product> GetProdotti()
            {
                return FGManager.Instance.Warehouse.ProductList;
            }
        }

        private class _FiltroEmpty : IFilterProducts
        {
            //Filtro che non filtra: restituisce una lista vuota
            public IEnumerable<Product> GetProdotti()
            {
                return new List<Product>();
            }
        }
    }
}
