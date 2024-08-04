using Helpers.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests.Shopping.Tests
{
    [TestClass]
    public class CartTest
    {
        private Cartİtem _cartİtem;
        private CartManager _cartManager;

        // her testten yani [TestMethoddan] önce çalışır  [TestCleanup] ise her test metodundan sonra çalışır örneğin _cartManager.Clear() ----- sadece tek test için yapılıp sonlanır sonra diğer test için yapılıp sonralınrlar.
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartİtem = new Cartİtem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };

            _cartManager.Add(_cartİtem);
        }

        [TestMethod]
        public void Sepete_urun_eklenebilmedilir()
        {
            //Arrange
            const int beklenen = 1;

            // Act
            var toplamElemanSayisi = _cartManager.TotalItems;
            Assert.AreEqual(beklenen, toplamElemanSayisi);
        }

        [TestMethod]
        public void Sepette_olan_urun_cikartilabilmeli()
        {
            //Arrange
            var sepetteolanelemansayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var sepettekalanelemansayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(sepetteolanelemansayisi - 1, sepettekalanelemansayisi);
            // birden fazla assert işlemi gerçekleştirilebilir.
        }


    }
}
