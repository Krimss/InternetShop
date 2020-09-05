using System.Linq;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;
namespace InternetShop.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }
        public IActionResult Index()
        {
            return View(cart.Lines);
        }
       [Route ("Cart/AddToCart")]
        public RedirectToActionResult AddToCart(int productId) {
            Product product = repository.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            cart.AddItem(product, 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
