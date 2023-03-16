using System.Linq;

namespace Mission09_yiywu.Models
{
    public interface ICartRepository
    {
        IQueryable<Cart> Carts { get; }
        public void SaveCart(Cart cart);

    }
}
