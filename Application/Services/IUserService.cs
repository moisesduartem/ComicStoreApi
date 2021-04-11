using System.Collections.Generic;
using System.Threading.Tasks;
using ComicStoreApi.Models;

namespace ComicStoreApi.Application.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}