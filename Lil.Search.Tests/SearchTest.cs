using Lil.Search.Controllers;
using Lil.Search.FakeServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Search.Tests
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void SearchReturnsOk()
        {
            var controller = new SearchController(new FakeCustomersService(), 
                    new FakeProductsService(), 
                    new FakeSalesService());

            var result = controller.SearchAsync("1").Result;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}