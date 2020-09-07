using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using InternetShop.Models;

namespace InternetShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration conf) => Configuration = conf;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<ICategoryRepository, EFCategoryRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseBrowserLink();
            _ = app.UseMvc(routes =>
              {
                  routes.MapRoute(
                      name: "Home",
                      template: "Home",
                      defaults: new { controller = "Home", action = "Index" }
                      );
                  routes.MapRoute(
                      name: null,
                      template: "Product{ProductId:int}",
                      defaults: new { controller = "ProductDatails", action = "Index" }
                      );
                  routes.MapRoute(
                      name: null,
                      template: "Cart",
                      defaults: new { controller = "Cart", action = "Index" }
                      );
                  routes.MapRoute(
                      name: null,
                      template: "products",
                      defaults: new { controller = "Products", action = "Index" }
                      );
              }

                );

           
        }
    }
}
