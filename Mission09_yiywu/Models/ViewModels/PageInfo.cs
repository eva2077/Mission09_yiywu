using System;

namespace Mission09_yiywu.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPages { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double) TotalNumBooks / BooksPerPages);
    }
}
