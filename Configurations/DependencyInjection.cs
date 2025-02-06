using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Dotnet.Models;
using Dotnet.Database;
using DotnetAppRoberto2.Services;
using DotnetAppRoberto2.Repositories;

namespace DotnetAppRoberto2.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<EmailService>();

            services.AddControllersWithViews();
            services.AddEndpointsApiExplorer();
            
            return services;
        }
    }
}