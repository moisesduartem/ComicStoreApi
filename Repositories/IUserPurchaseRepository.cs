using ComicStoreApi.Models;

namespace ComicStoreApi.Repositories
{
    public interface IUserPurchaseRepository
    {
        UserPurchase Register(UserPurchase purchase);
    }
}