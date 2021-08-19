using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
 
        [HttpGet("getall")]
        public IEnumerable<string> Get()
        {

            string[] customers = new string[] { "asdasd","asdasd"};

            return customers;
             
        }
    }
}
