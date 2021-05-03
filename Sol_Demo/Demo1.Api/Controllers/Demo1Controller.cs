using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Api.Controllers
{
    [Route("api/demo1")]
    [ApiController]
    public class Demo1Controller : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult GetDemo()
        {
            return base.Ok("Demo 1");
        }
    }
}