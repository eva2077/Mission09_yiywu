using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_yiywu.Components
{
    internal class View : IViewComponentResult
    {
        public View(IOrderedQueryable<string> types)
        {
            Types = types;
        }

        public IOrderedQueryable<string> Types { get; }

        public void Execute(ViewComponentContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task ExecuteAsync(ViewComponentContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}