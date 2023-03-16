using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Mission09_yiywu.Models
{
    public class EFCartRepository : ICartRepository
    {
        private BookstoreContext context;
        public EFCartRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Cart> Carts => context.Carts.Include(x => x.Lines).ThenInclude(x => x.Books);

        //Save the changes to the cart the the user made
        public void SaveCart(Cart cart)
        {
            context.AttachRange(cart.Lines.Select(x => x.Books));
            if (cart.cartId == 0)
            {
                context.Carts.Add(cart);
            }
            context.SaveChanges();

        }
    }
}
