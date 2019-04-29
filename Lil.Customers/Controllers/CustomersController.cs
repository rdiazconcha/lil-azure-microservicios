using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Customers.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersProvider customersProvider;
        public CustomersController(ICustomersProvider customersProvider)
        {
            this.customersProvider = customersProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var customer = await customersProvider.GetAsync(id);

            if (customer != null)
            {
                return Ok(customer);
            }

            return NotFound();
        }
    }
}
