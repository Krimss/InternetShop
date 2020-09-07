using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Models;
namespace InternetShop.Components
{
    public class CategoryComponent:ViewComponent
    {
        private ICategoryRepository categorys;
        public CategoryComponent(ICategoryRepository cat) => categorys = cat;
        public IViewComponentResult Invoke() {
            return View(categorys.Categorys);
        }
    }
}
