using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Sales.Models;

namespace Lil.Sales.DAL
{
    public interface ISalesProvider
    {
        Task<ICollection<Order>> GetAsync(string customerId);
    }
}
