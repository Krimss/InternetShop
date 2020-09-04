using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;

namespace InternetShop.Controllers
{
    public class ProductDatailsController : Controller
    {
        private IProductRepository repo;
        public ProductDatailsController(IProductRepository repository) => repo = repository;
        public IActionResult Index(int ProductID)
        {  
           return View(repo.Products.FirstOrDefault(p=>p.ProductId==ProductID));
        }
    }
}
