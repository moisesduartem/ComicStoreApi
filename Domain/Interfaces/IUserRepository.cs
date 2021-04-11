using ComicStoreApi.Domain.Models;

namespace ComicStoreApi.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        User GetByEmail(string email);
    }
}