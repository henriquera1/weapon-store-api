using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.Interfaces;
using web_store_api.Application.Mapping;
using web_store_api.Application.Services;
using web_store_api.Domain.Interfaces;
using web_store_api.Infra.Context;
using web_store_api.Infra.Repositories;

namespace web_store_api.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string mySqlConnection = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContextPool<AppDbContext>(options =>
                       options.UseMySql(mySqlConnection,
                           ServerVersion.AutoDetect(mySqlConnection)));

            services.AddScoped<IWeaponRepository, WeaponRepository>();
            services.AddScoped<IWeaponService, WeaponService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
