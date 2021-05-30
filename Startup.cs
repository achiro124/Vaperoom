using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Vaperoom.Manager;
using Vaperoom.Manager.Accounts;
using Vaperoom.Manager.Products;
using Vaperoom.Models;
using Vaperoom.Storage;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Vaperoom
{
    public class Startup
    {
        private IConfigurationRoot _confstring;
        [Obsolete]
        public Startup(IHostingEnvironment hostEnv)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MvcVapeShopContext>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            services.AddTransient<IProductManager, ProductManager>();
            services.AddTransient<IAccountManager, AccountManager>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

            services.AddMvc();
            services.AddControllersWithViews();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");

            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                MvcVapeShopContext content = scope.ServiceProvider.GetRequiredService<MvcVapeShopContext>();
                DBObjects.Initial(content);
            }

        }
    }
}
