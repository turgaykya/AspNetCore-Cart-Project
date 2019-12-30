using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWork.Northwind.Business.Abstract;
using CoreWork.Northwind.Business.Concrete.EntityFramework;
using CoreWork.Northwind.Data.Abstract;
using CoreWork.Northwind.Data.Concrete.EntityFramework;
using CoreWork.Northwind.MvcWebUI.Entities;
using CoreWork.Northwind.MvcWebUI.Middlewares;
using CoreWork.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreWork.Northwind.MvcWebUI
{
    public class Startup
    {
        //Servis yapılanmaları yapılıyor.Alt kısımdan gelen servisler burada gerçekleşir.
        public void ConfigureServices(IServiceCollection services)
        {
            //Üç tip servise türü var
            /*
             Singleton: olursa bir kere instance oluşur her istek onu kullanır.Ortak kullanıma aykırı olmaması gerekir.
             Scoped : her istekte yeni bir instance oluşur.

            Aralarındaki fark
            Tek kullanıcı aynı anda iki tane IProductService ihtiyacı duyarsa onun için aynı instance oluşur verilir.
            Transient aynı anda iki istekte onun için iki ayrı istek verir. Singleton da öyle.
             
             */
            //services.AddSingleton<IProductService, ProductManager>();
            //services.AddTransient<IProductService, ProductManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-509IM25;Database=Northwind;Trusted_Connection=true"));//User-Role
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSession();
            services.AddDistributedMemoryCache();//Bunu eklemezsek session aktifleşmemiş diye hata verir.
            services.AddMvc();
        }

        //Öncelikleri felan buradan belirliyoruz. Middleware kontrolleri burada yapılır.Sırasıyla çalışır.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseFileServer();//Node modules gibi dosyaları wwwroot ta tanımlamak istiyoruz.
            app.UseNodeModules(env.ContentRootPath);
            app.UseIdentity();

            app.UseSession();//Session kullan


            //Default olarak Home Controller sayfasına git
            app.UseMvcWithDefaultRoute();
        }
    }
}
