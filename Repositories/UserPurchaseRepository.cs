using System.Linq;
using System.Threading.Tasks;
using ComicStoreApi.Infra.Context;
using ComicStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicStoreApi.Repositories
{
    public class UserPurchaseRepository : IUserPurchaseRepository
    {
        private readonly ApplicationContext _context;

        public UserPurchaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public UserPurchase Register(UserPurchase purchase)
        {
            _context.UsersPurchases.Add(purchase);
            _context.SaveChanges();

            purchase.User = _context.Users.FirstOrDefault(u => u.Id == purchase.UserId);

            return purchase;
        }
    }
}