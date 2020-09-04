using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repo;
        public HomeController(IProductRepository repository) => repo = repository;
        public IActionResult Index()
        {
            return View(repo.Products);
        }
    }
}
