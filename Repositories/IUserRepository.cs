using ComicStoreApi.Models;

namespace ComicStoreApi.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User GetByEmail(string email);
    }
}