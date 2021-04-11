using ComicStoreApi.Application.Interfaces;
using ComicStoreApi.Application.Services;
using ComicStoreApi.Domain.Interfaces;
using ComicStoreApi.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ComicStoreApi.Infra
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserPurchaseService, UserPurchaseService>();
            service.AddScoped<IAccountService, AccountService>();

            service.AddScoped<IUserPurchaseRepository, UserPurchaseRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
        }
    }
}