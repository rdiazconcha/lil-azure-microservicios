using Lil.Sales.Controllers;
using Lil.Sales.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Sales.Tests
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var controller = new SalesController(new SalesProvider());
            var result = controller.GetAsync("1").Result;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var controller = new SalesController(new SalesProvider());
            var result = controller.GetAsync("1000").Result;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
