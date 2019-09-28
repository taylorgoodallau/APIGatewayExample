using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdersAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/orders
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetOrders()
        {
            var o1 = new Order("101",200);
            var o2 = new Order("102",300);
            return Ok(new List<Order>{ o1, o2 });
        }
    
    }

    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }

        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
            

        }
    }
}
