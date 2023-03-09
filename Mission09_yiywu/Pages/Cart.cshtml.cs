using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_yiywu.Infrastructure;
using Mission09_yiywu.Models;
using System.Linq;

namespace Mission09_yiywu.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepo repo { get; set; }

        public CartModel (IBookstoreRepo temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket")?? new Basket();
        }
        public IActionResult OnPost(int bookId, string returnUrl) 
        { 
            Books b = repo.Books.FirstOrDefault(x=> x.BookId == bookId);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1, b.Price);
            HttpContext.Session.SetJson("basket", basket);
            return RedirectToPage(new {ReturnUrl = returnUrl});
        }
    }
}
