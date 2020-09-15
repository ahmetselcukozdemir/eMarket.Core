using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Business.Abstract;
using eMarket.Core.Business.Concrete;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace eMarket.Core.Web.UI
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
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddSession(options =>
            {
                options.Cookie.Name = "eMarket.Core.Session";
                options.IdleTimeout = TimeSpan.FromHours(2);
                options.Cookie.IsEssential = true;
            });

            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAccountRepository, EfCoreAccountRepository>();
            services.AddScoped<IAccountService, AccountManager>();

            services.AddScoped<IMemberRepository, EfCoreMemberRepository>();
            services.AddScoped<IMemberService, MemberManager>();

            services.AddScoped<IAdminRepository, EfCoreAdminRepository>();
            services.AddScoped<IAdminService, AdminManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
