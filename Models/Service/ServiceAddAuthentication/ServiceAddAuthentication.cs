using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace OpenSourceEnity.Models.Service
{
    public static class ServiceAddAuthentication
    {
        public static IServiceCollection AddSerivceAuthentication(this IServiceCollection services) 
        {
            services.ConfigureApplicationCookie(option =>
            {
                option.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Authorization/Index");
                option.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Authorization/Index");
            });

            services.AddAuthorization(t =>
            {
                t.AddPolicy("User", t =>
                {
                    t.RequireClaim("Default", "User", "Пользователь");
                });

                t.AddPolicy("Area", t =>
                {
                    t.RequireClaim("Areas", "Russia" , "Россия");
                });
            });


            return services;
        }
    }
}
