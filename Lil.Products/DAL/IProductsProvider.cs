using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Products.Models;

namespace Lil.Products.DAL
{
    public interface IProductsProvider
    {
        Task<Product> GetAsync(string id);
    }
}
