using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.Service.ServiceConnection
{
    public static class IConnections
    {
        public static IServiceCollection AddServiceConnecction(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationEnityContextdb>(services => services.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationEnityContextdb>();

            return services;
        }
    }
}
