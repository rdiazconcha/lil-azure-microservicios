using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Search.Interfaces;
using Lil.Search.Models;

namespace Lil.Search.FakeServices
{
    public class FakeSalesService : ISalesService
    {
        private readonly List<Order> orders = new List<Order>();
        public FakeSalesService()
        {
            orders.Add(new Order()
            {
                CustomerId = "1",
                Id = "0001",
                OrderDate = DateTime.Now,
                Total = 10,
                Items = new List<OrderItem>()
                {
                    new OrderItem() { Id = 1, OrderId = "0001", Price = 10, ProductId = "1", Quantity = 1 }
                }
            });
        }
        public Task<ICollection<Order>> GetAsync(string customerId)
        {
            var result = orders.Where(o => o.CustomerId == customerId).ToList();
            return Task.FromResult((ICollection<Order>)result);
        }
    }
}
