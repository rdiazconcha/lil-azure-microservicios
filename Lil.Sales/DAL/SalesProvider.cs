using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Sales.Models;

namespace Lil.Sales.DAL
{
    public class SalesProvider : ISalesProvider
    {
        private readonly List<Order> repo = new List<Order>();
        public SalesProvider()
        {
            repo.Add(new Order()
            {
                Id = "0001",
                CustomerId = "1",
                OrderDate = DateTime.Now.AddMonths(-1),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0001", Id = 1, Price = 50, ProductId = "23", Quantity = 2},
                    new OrderItem(){ OrderId = "0001", Id = 2, Price = 50, ProductId = "4", Quantity = 1}
                }
            });
            repo.Add(new Order()
            {
                Id = "0002",
                CustomerId = "2",
                OrderDate = DateTime.Now.AddMonths(-2),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0002", Id = 1, Price = 50, ProductId = "23", Quantity = 2},
                    new OrderItem(){ OrderId = "0002", Id = 2, Price = 50, ProductId = "4", Quantity = 1}
                }
            });
            repo.Add(new Order()
            {
                Id = "0003",
                CustomerId = "2",
                OrderDate = DateTime.Now.AddMonths(-3),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0003", Id = 1, Price = 50, ProductId = "23", Quantity = 2},
                    new OrderItem(){ OrderId = "0003", Id = 2, Price = 50, ProductId = "4", Quantity = 1}
                }
            });
            repo.Add(new Order()
            {
                Id = "0004",
                CustomerId = "3",
                OrderDate = DateTime.Now.AddDays(-10),
                Total = 50,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0004", Id = 1, Price = 50, ProductId = "5", Quantity = 1}
                }
            });

        }
        public Task<ICollection<Order>> GetAsync(string customerId)
        {
            var orders = repo.Where(c => c.CustomerId == customerId).ToList();
            return Task.FromResult((ICollection<Order>)orders);
        }

    }
}
