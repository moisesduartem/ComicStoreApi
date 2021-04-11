using System.Linq;
using ComicStoreApi.Domain.Interfaces;
using ComicStoreApi.Domain.Models;
using ComicStoreApi.Infra.Context;

namespace ComicStoreApi.Domain.Repositories
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