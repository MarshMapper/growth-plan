using GrowthPlan.Domain.Entities;
using GrowthPlan.Application.Interfaces;
using Ardalis.Result.AspNetCore;

namespace GrowthPlan.Web.Endpoints
{
    public static class PlantEndpoints
    {
        public static void MapPlantGroup(this WebApplication app)
        {
            app.MapGroup("/plants")
                .MapPlantEndpoints();
        }
        public static RouteGroupBuilder MapPlantEndpoints(this RouteGroupBuilder plantGroup)
        {
            plantGroup.MapGet("", async (IPlantService plantService) =>
            {
                return (await plantService.GetAllAsync()).ToMinimalApiResult();
            });
            plantGroup.MapPut("", async (IPlantService plantService, Plant plant) =>
            {
                return (await plantService.UpdateAsync(plant)).ToMinimalApiResult();
            });
            plantGroup.MapPost("", async (IPlantService plantService, Plant plant) =>
            {
                return (await plantService.AddAsync(plant)).ToMinimalApiResult();
            });
            plantGroup.MapGet("{id}", async (IPlantService plantService, int id) =>
            {
                return (await plantService.GetByIdAsync(id)).ToMinimalApiResult();
            });
            plantGroup.MapDelete("{id}", async (IPlantService plantService, int id) =>
            {
                return (await plantService.DeleteAsync(id)).ToMinimalApiResult();
            });
            return plantGroup;
        }
    }
}
