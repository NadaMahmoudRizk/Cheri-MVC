using Cheri_Project.Models;
using Cheri_Project.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheri_Project
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
            services.AddScoped<IRepository<Categories>, CategoryServices>();
            services.AddScoped<IRepository<SubCategory>, SubCategoryServices>();

            services.AddScoped<IRepository<Product>, ProductServices>();
            services.AddScoped<IRepository<Image>, ImagesServices>();
            services.AddScoped<IRepository<Size>, SizeServices>();
            services.AddScoped<IRepository<Color>, ColorServices>();
            services.AddScoped<IRepository<Product_Order>, Product_OrderServices>();
            //  services.AddScoped<IRepository<Product>, ProductServices>();
            services.AddDbContext<Cheri>(Options =>
                 Options.UseSqlServer(Configuration.GetConnectionString("Local")));
            services.AddIdentity<IdentityUser, IdentityRole>(optios =>
            {
                optios.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<Cheri>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=LoginPage}/{id?}");


            });
        }
    }
}

