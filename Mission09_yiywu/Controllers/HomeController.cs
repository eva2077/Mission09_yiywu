using Microsoft.AspNetCore.Mvc;
using Mission09_yiywu.Models;
using Mission09_yiywu.Models.ViewModels;
using System.Linq;

namespace Mission09_yiywu.Controllers
{
    public class HomeController : Controller
    {
        private IBookstore repo;
        public HomeController(IBookstore temp)
        {
            repo = temp;
        } 
        //skip and take data for page number 
        public IActionResult Index(int pageNum=1)
        {
            int pageSize = 10;


            var y = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPages = pageSize,
                    CurrentPage = pageNum
                }
            };
            return View(y);
        }
    }
}
