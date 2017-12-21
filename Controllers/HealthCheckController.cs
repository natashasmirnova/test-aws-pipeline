using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore_api.Controllers
{
    [Route("[controller]")]
    [Route("")]
    public class HealthCheckController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }

        [HttpGet("helloworld")]
        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}
