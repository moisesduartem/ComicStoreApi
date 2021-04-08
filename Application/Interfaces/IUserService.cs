using System.Collections.Generic;
using System.Threading.Tasks;
using ComicStoreApi.Domain;

namespace ComicStoreApi.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}