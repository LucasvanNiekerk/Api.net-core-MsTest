using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeatherInformationsController cr = new WeatherInformationsController();
            var a = cr.Get();

            Assert.IsTrue(a.Any());
        }
    }
}
