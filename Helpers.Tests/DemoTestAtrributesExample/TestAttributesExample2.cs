using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests.DemoTestAtrributesExample
{
    [TestClass]
    public class TestAttributesExample2
    {
        [TestMethod, Ignore] // Ignore Bu Testi pas geçer
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
    
        [TestMethod, Description("açıkalama")] //description açıklama yazar , gereksin ismi test metodu olmalı fakat bazen uzun bir açıklama gerekebilir.
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(1000)] // timeout: 1 sn üzerinde sürer ise timeouta girer ve test fail olur
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(1000)] // timeout: 1 sn üzerinde sürer ise timeouta girer ve test fail olur
        public void TestMethod4()
        {
            Thread.Sleep(1500);

            Assert.AreEqual(1, 1);
        }

        [TestMethod,Timeout(TestTimeout.Infinite)] // sonsuz süre: default 30 dk olabilir.
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
