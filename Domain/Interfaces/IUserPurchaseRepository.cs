using ComicStoreApi.Domain.Models;

namespace ComicStoreApi.Domain.Interfaces
{
    public interface IUserPurchaseRepository
    {
        UserPurchase Register(UserPurchase purchase);
    }
}