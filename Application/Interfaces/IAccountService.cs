using ComicStoreApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Interfaces
{
    public interface IAccountService
    {
        User Register([FromBody] User model);
        User Authenticate([FromBody] User model);
    }
}