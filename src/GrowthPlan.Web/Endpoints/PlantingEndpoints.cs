using GrowthPlan.Domain.Entities;
using GrowthPlan.Application.Interfaces;
using Ardalis.Result.AspNetCore;

namespace GrowthPlan.Web.Endpoints
{
    public static class PlantingEndpoints
    {
        public static void MapPlantingGroup(this WebApplication app)
        {
            app.MapGroup("/plantings")
                .MapPlantingEndpoints();
        }
        public static RouteGroupBuilder MapPlantingEndpoints(this RouteGroupBuilder plantingGroup)
        {
            plantingGroup.MapGet("", async (IPlantingService plantingService) =>
            {
                return (await plantingService.GetAllAsync()).ToMinimalApiResult();
            });
            plantingGroup.MapPut("", async (IPlantingService plantingService, Planting planting) =>
            {
                return (await plantingService.UpdateAsync(planting)).ToMinimalApiResult();
            });
            plantingGroup.MapPost("", async (IPlantingService plantingService, Planting planting) =>
            {
                return (await plantingService.AddAsync(planting)).ToMinimalApiResult();
            });
            plantingGroup.MapGet("{id}", async (IPlantingService plantingService, int id) =>
            {
                return (await plantingService.GetByIdAsync(id)).ToMinimalApiResult();
            });
            plantingGroup.MapDelete("{id}", async (IPlantingService plantingService, int id) =>
            {
                return (await plantingService.DeleteAsync(id)).ToMinimalApiResult();
            });
            return plantingGroup;
        }
    }
}
