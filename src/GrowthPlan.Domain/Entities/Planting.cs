#nullable disable
using System.Text.Json.Serialization;

namespace GrowthPlan.Domain.Entities;

public partial class Planting
{
    public int PlantingId { get; set; }

    public int PlantId { get; set; }

    public string Description { get; set; }

    public int? Count { get; set; }

    public DateTime? SeedPlanted { get; set; }

    public string Notes { get; set; }
    [JsonIgnore]

    public virtual Plant Plant { get; set; }
}