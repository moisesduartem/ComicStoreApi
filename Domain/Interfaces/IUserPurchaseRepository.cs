using System.Collections.Generic;
using ComicStoreApi.Domain.Models;

namespace ComicStoreApi.Domain.Interfaces
{
    public interface IUserPurchaseRepository
    {
        UserPurchase Register(UserPurchase purchase);
        List<UserPurchase> GetAllByUserId(int userId);
    }
}