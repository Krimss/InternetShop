using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;

namespace InternetShop.Controllers
{
    public class Products : Controller
    {
        private IProductRepository repo;
        public Products(IProductRepository repository) => repo = repository;
        public IActionResult Index(int CategoryID=0)

        {
            IQueryable<Product> products=CategoryID==0?repo.Products:repo.Products.Where(p=>p.CategoryId==CategoryID) ;
            
            return View(products);
        }
    }
}
