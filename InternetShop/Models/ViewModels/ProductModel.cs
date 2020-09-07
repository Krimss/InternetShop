using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Models;

namespace InternetShop.Models.ViewModels
{
    public class ProductModel
    {
        public Product Product { get; set; }
        public string ReturnUrl { get; set; }
    }
}
