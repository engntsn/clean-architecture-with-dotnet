using Application.Repositories;
using Infrastructure.DbContext;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceCollectionExtensions
{
    public static  IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
                .AddTransient<IPropertyRepo, PropertyRepo>();
        
    }
}