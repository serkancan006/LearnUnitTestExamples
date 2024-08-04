using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Shopping
{
    public class CartManager
    {
        private readonly List<Cartİtem> _cartİtems;

        public CartManager()
        {
            _cartİtems = new List<Cartİtem>();
        }

        public void Add(Cartİtem cartİtem)
            => _cartİtems.Add(cartİtem);

        public void Clear()
            => _cartİtems.Clear();

        public void Remove(int productId)
        {
            var product = _cartİtems.FirstOrDefault(t => t.Product.ProductId == productId);

            _cartİtems.Remove(product);
        }

        public List<Cartİtem> Cartİtems => _cartİtems;

        public int TotalQuantity => _cartİtems.Sum(x => x.Quantity);

        public int TotalItems => _cartİtems.Count;

    }
}
