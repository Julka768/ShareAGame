using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareAGame.DataAccess;
using ShareAGame.Repositories.Interfaces;
using ShareAGame.Repositories.Repositories;

namespace ShareAGameAPI.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureCors(this IServiceCollection services) =>
                services.AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin() //WithOrigins("https://example.com")
                    .AllowAnyMethod() //WithMethods("POST", "GET")
                    .AllowAnyHeader()); //WithHeaders("accept", "contenttype")
                });
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ShareAGameContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
            b.MigrationsAssembly("ShareAGame.DataAccess")));

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGameRepository, GameRepository>();
        }


    }
}
