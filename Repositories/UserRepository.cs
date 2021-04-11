using System.Linq;
using System.Threading.Tasks;
using ComicStoreApi.Infra.Context;
using ComicStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicStoreApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetByEmail(string email)
        {
            return _context.Users.AsNoTracking().FirstOrDefault(x =>
                x.Email.ToLower() == email.ToLower()
            );
        }
    }
}