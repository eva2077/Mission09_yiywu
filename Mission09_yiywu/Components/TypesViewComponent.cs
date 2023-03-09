using Microsoft.AspNetCore.Mvc;
using Mission09_yiywu.Models;
using System.Linq;

namespace Mission09_yiywu.Components
{
    public class TypesViewComponent: ViewComponent
    {
        private IBookstoreRepo repo { get; set; }
        public TypesViewComponent(IBookstoreRepo temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData.Values["BookCategory"];
            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }
}
