using System.Collections.Generic;
using System.Linq;

namespace Mission09_yiywu.Models
{
    public class Basket
    {
        public IList<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();
        public double Price { get; private set; }

        public void AddItem(Books book, int qty, double price)
        {
            BasketLineItem line = Items
                .Where(b => b.Books.BookId == book.BookId)
                .FirstOrDefault();
            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Books = book,
                    Quantity = qty,
                    Price = price
                });
            }
            else
            {
                line.Quantity += qty;
            }
            Price = CalcTotal();
        }

        public double CalcTotal()
        {
            return Items.Sum(x => x.Quantity * x.Price);
        }
    }

    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Books Books { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}