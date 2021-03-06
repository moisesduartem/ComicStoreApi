using System.Collections.Generic;
using System.Threading.Tasks;
using ComicStoreApi.Domain.Models;

namespace ComicStoreApi.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}