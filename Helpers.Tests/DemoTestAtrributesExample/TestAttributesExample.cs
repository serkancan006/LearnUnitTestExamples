using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests.DemoTestAtrributesExample
{
    [TestClass]
    public class TestAttributesExample
    {
        [TestMethod]
        [Owner("Serkan")] // testi kimin yazdığını belirtir. // test gezgininde görmüş olursun // fakat sıralama ayarını yapman gerek niteliklere çek sıralamayı test gezgininde
        [TestCategory("TesterGrup1")] // Testleri gruplamak için
        [Priority(1)] // önceliğe göre gruplar
        [TestProperty("Güncelleyen", "Serkan")] // özel durumlara göre kendi gruplama sistemimizi yapyoruz GÜncelleyen ve Serkan olarak aynısından bir daha olamaz
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [Owner("Serkan")] // testi kimin yazdığını belirtir.
        [TestCategory("TesterGrup1")] // Testleri gruplamak için
        [Priority(2)]
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [Owner("Mehmet")] // testi kimin yazdığını belirtir.
        [TestCategory("TesterGrup2")] // Testleri gruplamak için
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [Owner("Mehmet")] // testi kimin yazdığını belirtir.
        [TestCategory("TesterGrup2")] // Testleri gruplamak için
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [Owner("Mehmet")] // testi kimin yazdığını belirtir.
        [TestCategory("TesterGrup2")] // Testleri gruplamak için
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
