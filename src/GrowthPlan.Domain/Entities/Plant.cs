#nullable disable
using System.Text.Json.Serialization;

namespace GrowthPlan.Domain.Entities;

public partial class Plant
{
    public int PlantId { get; set; }

    public string CommonName { get; set; }

    public string ScientificName { get; set; }

    public int? GerminationDays { get; set; }

    public int? DaysToPot { get; set; }

    public int? DaysToOutdoors { get; set; }
    [JsonIgnore]

    public virtual ICollection<Planting> Plantings { get; set; } = new List<Planting>();
}