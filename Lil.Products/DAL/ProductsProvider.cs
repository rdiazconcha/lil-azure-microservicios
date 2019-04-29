using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Products.Models;

namespace Lil.Products.DAL
{
    public class ProductsProvider : IProductsProvider
    {
        private List<Product> repo = new List<Product>();
        public ProductsProvider()
        {
            for (int i = 0; i < 100; i++)
            {
                repo.Add(new Product()
                {
                    Id = (i+1).ToString(),
                    Name = $"Producto {i+1}",
                    Price = i * 3.14
                });
            }
        }
        public Task<Product> GetAsync(string id)
        {
            var product = repo.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }
    }
}
