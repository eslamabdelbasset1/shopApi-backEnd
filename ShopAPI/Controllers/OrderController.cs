using Microsoft.AspNetCore.Mvc;
using ShopAPI.DBContexts;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 
namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
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


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {


            return this.mySqlDbContext.Orders.Find(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
