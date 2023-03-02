using Mission09_yiywu.Controllers;
using System.Linq;

namespace Mission09_yiywu.Models
{
    public class EFBookstoreRepo : IBookstore
    {
        private BookstoreContext context { get; set; }
        public EFBookstoreRepo(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;
    }
}
