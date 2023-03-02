using System.Linq;

namespace Mission09_yiywu.Models.ViewModels
{
    //what is shown per page and gets the info from the PageInfo.cs
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}

