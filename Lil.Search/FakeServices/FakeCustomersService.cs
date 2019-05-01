using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Search.Interfaces;
using Lil.Search.Models;

namespace Lil.Search.FakeServices
{
    public class FakeCustomersService : ICustomersService
    {
        private readonly List<Customer> repo = new List<Customer>();
        public FakeCustomersService()
        {
            repo.Add(new Customer() { Id = "1", Name = "Customer 1", City = "City" });
        }
        public Task<Customer> GetAsync(string id)
        {
            var customer = repo.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(customer);
        }
    }
}