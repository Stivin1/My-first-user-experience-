using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Logger.LoggerAuthorization;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.Service;
using OpenSourceEnity.Models.Service.ServiceAggregate;
using OpenSourceEnity.Models.Service.ServiceConnection;
using OpenSourceEnity.Models.Service.ServiceMiddleware.AuthenticationMiddleware;
using OpenSourceEnity.Models.Service.ServiceSession;
using System;
using System.Linq;

namespace OpenSourceEnity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServiceConnecction(Configuration);

            services.AddServiceAgregate();

            services.AddSerivceAuthentication();

            services.AddControllersWithViews();

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.Name = ".AspApplicationUser.A009S230S12E";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

            app.UseMiddleware<AuthenUserRequestMiddleware>();

            app.UseMiddleware<AuthenticationsMiddleware>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Front}/{action=Index}/{id?}");
            });

        }
    }
}
