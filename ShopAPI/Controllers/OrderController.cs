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

    public class OrderController : ControllerBase
    {
        private MySqlDBContext mySqlDbContext;
       
        public OrderController(MySqlDBContext context)
        {
            this.mySqlDbContext = context;
        }

        // GET: api/<cust>
        [HttpGet]
        public IEnumerable<Order> Get()    
        {
            return this.mySqlDbContext.Orders.ToList();
        }

        // GET <ValuesController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return this.mySqlDbContext.Orders.Find(id);
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
