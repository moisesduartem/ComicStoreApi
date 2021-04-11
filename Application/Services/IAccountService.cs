using ComicStoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Services
{
    public interface IAccountService
    {
        User Register([FromBody] User model);
        User Authenticate([FromBody] User model);
    }
}