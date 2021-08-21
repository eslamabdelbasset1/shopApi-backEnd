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


    public class OrderDetailsController : ControllerBase
    {
        private MySqlDBContext mySqlDbContext;


        public OrderDetailsController(MySqlDBContext context)
        {
            this.mySqlDbContext = context;
        }

        // GET: api/<cust>
        [HttpGet]
        public IEnumerable<OrderDetail> Get()
        {

            return this.mySqlDbContext.Orderdetails.ToList();
        }




        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public OrderDetail Get(int id)
        {


            return this.mySqlDbContext.Orderdetails.Find(id);
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
