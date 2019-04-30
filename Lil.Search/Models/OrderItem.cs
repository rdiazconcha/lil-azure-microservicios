using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Search.Models
{
    public class OrderItem
    {
        public string OrderId { get; set; }

        public int Id { get; set; }

        public string ProductId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }
    }
}
