using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class ExampleTestContext
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Example() 
        {
            TestContext.WriteLine($"Şuanki Test Adı: {TestContext.TestName}"); //Test gezgininde görülür
        }
    }
}
