using ComicStoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Services
{
    public interface IUserPurchaseService
    {
        UserPurchase Register([FromBody] UserPurchase model);
    }
}