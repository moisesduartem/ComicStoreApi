using System.Collections.Generic;
using System.Linq;
using ComicStoreApi.Domain.Interfaces;
using ComicStoreApi.Domain.Models;
using ComicStoreApi.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace ComicStoreApi.Domain.Repositories
{
    public class UserPurchaseRepository : IUserPurchaseRepository
    {
        private readonly ApplicationContext _context;

        public UserPurchaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<UserPurchase> GetAllByUserId(int userId)
        {
            var purchases = _context.UsersPurchases.Where(p => p.UserId == userId).ToList();
            return purchases;
        }

        public UserPurchase Register(UserPurchase purchase)
        {
            _context.UsersPurchases.Add(purchase);
            _context.SaveChanges();

            return purchase;
        }
    }
}