using GrowthPlan.Application.Interfaces;
using GrowthPlan.Application.Services;
using GrowthPlan.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GrowthPlan.Infrastructure
{
    public static class GrowthPlanExtensions
    {
        public static void AddGrowthPlan(this IServiceCollection services,
            ConfigurationManager configurationManager)
        {
            services.AddDbContext<GrowthPlanDatabaseContext>(
                        options => options.UseSqlServer(configurationManager.GetConnectionString("GrowthPlanConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPlantService, PlantService>();
            services.AddScoped<IPlantingService, PlantingService>();

        }
    }
}