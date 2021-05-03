using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo2.Api.Controllers
{
    [Route("api/demo2")]
    [ApiController]
    public class Demo2Controller : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult GetDemo()
        {
            return base.Ok("Demo 2");
        }
    }
}