using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Search.Interfaces;
using Lil.Search.Models;

namespace Lil.Search.FakeServices
{
    public class FakeProductsService : IProductsService
    {
        private List<Product> repo = new List<Product>();
        public FakeProductsService()
        {
            repo.Add(new Product() { Id = "1", Name = "Product 1", Price = 10 });
        }

        public Task<Product> GetAsync(string id)
        {
            var product = repo.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }
    }
}
