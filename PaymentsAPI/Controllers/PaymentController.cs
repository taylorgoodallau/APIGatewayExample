using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaymentsAPI.Controllers
{
    [Route("api/charge")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/valuesp
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Payment Processed" };
        }


    }
}
