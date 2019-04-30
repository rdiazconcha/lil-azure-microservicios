using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Search.Models;

namespace Lil.Search.Interfaces
{
    public interface ISalesService
    {
        Task<ICollection<Order>> GetAsync(string customerId);
    }
}
