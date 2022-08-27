using Adni.Application.Common.Interfaces;
using Adni.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureData(this IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=AdniDatabse.sqlite3"));
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(@"host=localhost:5432;database=adniDB;user id=adniSYS;password=00000;"));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            return services;
        }
    }
}
