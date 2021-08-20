using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class 
        Customer
    {
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public float CreditLimit { get; set; }


    }
}
