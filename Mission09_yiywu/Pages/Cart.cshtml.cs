using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_yiywu.Infrastructure;
using Mission09_yiywu.Models;
using System.Linq;

namespace Mission09_yiywu.Pages
{
    //help navigate the routes when user adds book to cart
    public class CartModel : PageModel
    {
        private IBookstoreRepo repo { get; set; }

        public CartModel (IBookstoreRepo temp,Basket b)
        {
            repo = temp;
            basket= b;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(int bookId, string returnUrl) 
        { 
            Books b = repo.Books.FirstOrDefault(x=> x.BookId == bookId);
           
            basket.AddItem(b, 1, b.Price);
      
            return RedirectToPage(new {ReturnUrl = returnUrl});
        }
        public IActionResult OnPostRemove( int BookId,string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Books.BookId == BookId).Books);
            return RedirectToPage(new {ReturnUrl = returnUrl});
        }
    }
}
