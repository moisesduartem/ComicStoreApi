using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicStoreApi.Application.Interfaces;
using ComicStoreApi.Domain;
using ComicStoreApi.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace ComicStoreApi.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }
    }
}