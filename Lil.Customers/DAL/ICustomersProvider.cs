using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Customers.Models;

namespace Lil.Customers.DAL
{
    public interface ICustomersProvider
    {
        Task<Customer> GetAsync(string id);
    }
}
