using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mission09_yiywu.Infrastructure;
using System;
using System.Text.Json.Serialization;



//keeps track of all the information for the sesession
namespace Mission09_yiywu.Models
{
    public class SessionBasket : Basket
    {
        //Checks if there is already a session open
        public static Basket GetBasket (IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionBasket basket = session?.GetJson<SessionBasket>("Basket") ?? new SessionBasket();
            basket.Session = session;
            return basket;  
        }
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Books book, int qty, double price)
        {
            base.AddItem(book, qty, price);
            Session.SetJson("Basket", this);

        }
        public override void RemoveItem(Books book)
        {
            base.RemoveItem(book);
            Session.SetJson("Basket", this);
        }
        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }
    }
}
