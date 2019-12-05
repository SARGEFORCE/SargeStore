using SargeStore.ViewModels;

namespace SargeStore.Infrastructure.Interfaces
{
    public interface ICartService
    {
        void AddToCart(int id);
        void DecrementFromCart(int id);
        void RemoveFromCart(int id);
        void RemoveAll();
        CartViewModel TransformFromCart();
    }
}
