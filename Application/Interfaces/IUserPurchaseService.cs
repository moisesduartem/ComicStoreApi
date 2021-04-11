using System.Collections.Generic;
using ComicStoreApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Interfaces
{
    public interface IUserPurchaseService
    {
        UserPurchase Register([FromBody] UserPurchase model);
        List<UserPurchase> GetPurchasesByUserId(int userId);
    }
}