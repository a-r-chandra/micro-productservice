using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Models
{
    public class Product
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
    }
}
