using App.Entities.Concrete;
using WebUIOfECommerceProject.ExtentionMethods;

namespace WebUIOfECommerceProject.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _contextAccessor;

        public CartSessionService(HttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartToCheck = _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if(cartToCheck== null)
            {
                _contextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck; 
        }

        public void SetCart(Cart cart)
        {
            _contextAccessor.HttpContext.Session.SetObject("cart",cart);
        }
    }
}
