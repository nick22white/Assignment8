using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        //used to create summary
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}