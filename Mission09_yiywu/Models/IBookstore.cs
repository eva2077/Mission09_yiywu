using System.Linq;

namespace Mission09_yiywu.Models
{
    public interface IBookstoreRepo
    {
        IQueryable<Books> Books { get; }
    }
}
