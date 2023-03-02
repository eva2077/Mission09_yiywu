using System;

namespace Mission09_yiywu.Models.ViewModels
    //how many pages and book per a page
{ 
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPages { get; set; }
        public int CurrentPage { get; set; }

        //allow deciamals when calculating the books shown per page

        public int TotalPages => (int)Math.Ceiling((double) TotalNumBooks / BooksPerPages);
    }
}
