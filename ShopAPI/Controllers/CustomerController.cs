﻿using Microsoft.AspNetCore.Mvc;
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

    public class CustomerController : ControllerBase
    {
        private MySqlDBContext mySqlDbContext;

        public CustomerController(MySqlDBContext context)
        {
            this.mySqlDbContext = context;
        }

        // GET: <cust>
        [HttpGet]
        public IEnumerable<Customer> Get()    
        {
            return this.mySqlDbContext.Customers.ToList();
        }

        // GET: <CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {


            return this.mySqlDbContext.Customers.Find(id);
        }

        // POST <Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT <CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
