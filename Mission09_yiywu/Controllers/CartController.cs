using Microsoft.AspNetCore.Mvc;
using Mission09_yiywu.Models;
using System.Linq;

namespace Mission09_yiywu.Controllers
{
    public class CartController : Controller
    {
        private ICartRepository repo {get; set;}
        private Basket basket { get; set;}
        public CartController(ICartRepository temp,Basket b)
        {
            repo = temp;
            basket = b;
        }
        //Get information from checkout page
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Cart());
        }
        //post the information on the cart page
        [HttpPost]
        public IActionResult Checkout(Cart cart)
        {
            if ( basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry,your cart is empty");

            }
            //Look at items in our basket and add them to cart lines
            if (ModelState.IsValid)
            { 
                cart.Lines = basket.Items.ToArray();
                repo.SaveCart(cart);
                basket.ClearBasket();

                return RedirectToPage("/CartSubmitted");
            }
            else
            {
                return View();
            }
        }
    }
}
