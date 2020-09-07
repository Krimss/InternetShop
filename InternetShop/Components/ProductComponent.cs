using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Models;
using InternetShop.Models.ViewModels;


namespace InternetShop.Components
{
    public class ProductComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke(Product product,string returnUrl) 
        {
            return View(new ProductModel {Product=product,ReturnUrl=returnUrl });
        }
    }
}
