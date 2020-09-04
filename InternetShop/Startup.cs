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
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseMvc(routes=>
            {
                routes.MapRoute(
                    name: "Home",
                    template: "Home",
                    defaults: new { controller = "Home", action = "Index" }
                    );
                routes.MapRoute(
                    name: null,
                    template: "Product/{ProductId:int}",
                    defaults: new { controller = "ProductDatails", action ="Index"  }
                    ) ;
            }
                
                );

           
        }
    }
}
