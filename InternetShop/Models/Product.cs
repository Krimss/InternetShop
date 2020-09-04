using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int Specifications { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public int Discount { get; set; }
        public int Rang { get; set; }

    }
}
