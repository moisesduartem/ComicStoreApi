using ComicStoreApi.Application.Interfaces;
using ComicStoreApi.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ComicStoreApi.Infra
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
        }
    }
}