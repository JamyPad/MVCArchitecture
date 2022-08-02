
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.BL.DTO;
using Shop.BL.IRepositories;
using Shop.BL.IService;
using Shop.BL.Models;
using Shop.BL.Service;
using Shop.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApp
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
            services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.WriteIndented = true);
            services.AddControllersWithViews();

            services.AddDbContext<codeContext>(options =>
           options.UseSqlServer("Data Source=.;Initial Catalog=codeShop;Integrated Security=True"));

            services.AddAutoMapper(c => c.AddProfile<AutoMapping>(), typeof(Startup));

            services.AddMvc();
            services.AddControllers();

            services.AddScoped<codeContext>();


 
       
            services.AddScoped<IRepository<Employee>, EmployeeRepository>();
            services.AddScoped<IServiceBase<EmployeeDTO>, EmployeeService>();
            services.AddScoped<IRepository<Employee>, EmployeeRepository>();
            services.AddScoped<IServiceBase<EmployeeDTO>, EmployeeService>();



            //services.AddScoped<IServiceBase<EmployeeDTO>, EmployeeService();
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
                app.UseExceptionHandler("/Employee/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employee}/{action=Index}/{id?}");
            });
        }
    }
}
