using App.Entities.Concrete;

namespace WebUIOfECommerceProject.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
