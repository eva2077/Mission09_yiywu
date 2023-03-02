using System.Linq;

namespace Mission09_yiywu.Models
{
    public interface IBookstore
    {
        IQueryable<Books> Books { get; }
    }
}
