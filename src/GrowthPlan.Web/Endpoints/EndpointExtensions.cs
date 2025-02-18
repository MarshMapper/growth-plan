namespace GrowthPlan.Web.Endpoints
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapPlantGroup();
            app.MapPlantingGroup();
        }
    }
}
