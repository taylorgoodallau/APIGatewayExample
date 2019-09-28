﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/currencies
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "aud" };
        }


    }
}
