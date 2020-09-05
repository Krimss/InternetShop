using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Models;

namespace InternetShop.Components
{    
   
    public class CartComponent:ViewComponent
    {
        private Cart cart;
        public CartComponent(Cart cartService) {
            cart = cartService;
        }
        public IViewComponentResult Invoke() {
            return View(cart.Lines.Count());
        }
    }
}
