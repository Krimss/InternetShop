using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Categorys
    {[Key]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
