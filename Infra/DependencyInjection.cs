using ComicStoreApi.Application.Services;
using ComicStoreApi.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ComicStoreApi.Infra
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IAccountService, AccountService>();
            service.AddScoped<IUserRepository, UserRepository>();
        }
    }
}