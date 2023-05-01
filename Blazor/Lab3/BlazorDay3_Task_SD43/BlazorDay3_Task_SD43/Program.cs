using BlazorDay3_Task_SD43.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlazorDay3_Task_SD43.Data;

namespace BlazorDay3_Task_SD43
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("BlazorDay3_Task_SD43ContextConnection") ?? throw new InvalidOperationException("Connection string 'BlazorDay3_Task_SD43ContextConnection' not found.");

            builder.Services.AddDbContext<BlazorDay3_Task_SD43Context>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BlazorDay3_Task_SD43Context>();

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddAuthentication("Identity.Application").AddCookie();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddHttpClient<ITraineeService, TraineeServiceRepo>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7181");
            });
            builder.Services.AddHttpClient<ITrackService, TrackServiceRepo>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7181");
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            
            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}