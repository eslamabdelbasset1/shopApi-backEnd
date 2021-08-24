using Microsoft.AspNetCore.Mvc;
using ShopAPI.DBContexts;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class OrderDetailsController : ControllerBase
    {
        private MySqlDBContext mySqlDbContext;

        public OrderDetailsController(MySqlDBContext context)
        {
            this.mySqlDbContext = context;
        }

        // GET: <cust>
        [HttpGet]
        public IEnumerable<OrderDetail> Get()
        {
            return this.mySqlDbContext.Orderdetails.ToList();
        }

        // GET <ValuesController>/5
        [HttpGet("{id}")]
        public OrderDetail Get(int id)
        {
            return this.mySqlDbContext.Orderdetails.Find(id);
        }

        // POST <ValuesController>
        [HttpPost]
        public void Post([FromBody] string value) { }

        // PUT <ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE <ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
