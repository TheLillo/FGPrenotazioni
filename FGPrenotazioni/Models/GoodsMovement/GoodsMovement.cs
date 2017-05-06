using FGPrenotazioni.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.GoodsMovements
{
    [Serializable]
    public abstract class GoodsMovement
    {
        private List<Product> _productsToMove;

        public List<Product> ProductsToMove
        {
            get
            {
                return _productsToMove;
            }
        }

        public GoodsMovement(List<Product> _productsToMove)
        {
            if (_productsToMove == null || _productsToMove.Count==0)
                throw new ArgumentNullException("Lista prodotti vuota!");
            this._productsToMove = _productsToMove;
        }

        public abstract string toFullString();
    }
}
