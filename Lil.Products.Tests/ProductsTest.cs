using Lil.Products.Controllers;
using Lil.Products.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var productsController = new ProductsController(new ProductsProvider());
            var result = productsController.GetAsync("1").Result;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var productsController = new ProductsController(new ProductsProvider());
            var result = productsController.GetAsync("10000").Result;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
