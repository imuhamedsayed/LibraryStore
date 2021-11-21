using BookStore.BL.Interface;
using BookStore.BL.Mapper;
using BookStore.BL.Models;
using BookStore.BL.Repository;
using BookStore.DAL.Database;
using BookStore.Presentation.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
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
            services.AddControllersWithViews()
                .AddFluentValidation();

            services.AddDbContextPool<BookStoreDbContext>(opts =>
           opts.UseSqlServer(Configuration.GetConnectionString("BookStoreConnection")));

            services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

            services.AddScoped<IBooksRepository, BooksRepository>();
            services.AddScoped<IBorrowerRepository, BorrowerRepository>();
            services.AddScoped<IBorrowerBookRepository,BorrowerBookRepository > ();
          

            services.AddTransient<IValidator<CreateBookVm>, BookValidator>();
            services.AddTransient<IValidator<CreateBorrowerVM>, BorrowerValidator>();
            services.AddTransient<IValidator<UpdateBookVm>, UpdateBookValidator>();
            services.AddTransient<IValidator<UpdateBorrowerVM>, UpdateBorrowerValidator>();

            services.AddTransient<IValidator<BorrowBookVM>, BorrowerBookValidator>();






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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Books}/{action=Index}/{id?}");
            });
        }
    }
}
