using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int CustomerNumber { get; set; }
       
    }
}
