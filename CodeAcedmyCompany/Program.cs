using AutoMapper;
using CodeAcedmyCompany.BLL.Interface;
using CodeAcedmyCompany.BLL.repository;
using CodeAcedmyCompany.DAL.Context;
using CodeAcedmyCompany.ProfileModel;
using Microsoft.EntityFrameworkCore;

namespace CodeAcedmyCompany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>
                (
                options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddAutoMapper(m=>m.AddProfile(new DepartmentProfile()));
            builder.Services.AddAutoMapper(m => m.AddProfile(new employeeprofile()));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
