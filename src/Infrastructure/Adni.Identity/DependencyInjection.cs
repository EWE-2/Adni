using Adni.Application.Common.Interfaces;
using Adni.Identity.Helpers;
using Adni.Identity.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Adni.Identity
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureIdentify(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<AuthSettings>(config.GetSection(nameof(AuthSettings)));
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
