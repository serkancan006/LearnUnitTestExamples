using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            // Arrange: Hazırlıklar
            var ifade = "   Serkan Can   ";
            var beklenen = "Serkan Can";

            // Act: gerçekleşen işlemler sınıf kullanılarak elde edilenler
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            // Assert: beklenen sonuçlar
            Assert.AreEqual(beklenen, gerceklesen);
        }

        [TestMethod]
        public void girilen_ifadenin_icindeki_fazla_bosluklar_silinlemelidir()
        {
            // Arrange: Hazırlıklar
            var ifade = "Serkan    Can     Kaya";
            var beklenen = "Serkan Can Kaya";

            // Act: 
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            // Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }



    }
}


