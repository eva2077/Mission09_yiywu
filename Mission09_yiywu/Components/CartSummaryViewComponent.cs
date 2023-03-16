using Microsoft.AspNetCore.Mvc;
using Mission09_yiywu.Models;

namespace Mission09_yiywu.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Basket _basket;

        public CartSummaryViewComponent(Basket basket)
        {
            _basket = basket;
        }

        public IViewComponentResult Invoke()
        {
            return View(_basket);
        }
    }
}