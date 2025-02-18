using FluentValidation;
using GrowthPlan.Application.Interfaces;
using GrowthPlan.Application.Validators;
using GrowthPlan.Domain.Entities;

namespace GrowthPlan.Application.Services
{
    public class PlantingService : CrudService<Planting>, IPlantingService
    {
        public PlantingService(IRepository<Planting> repository) : base(repository)
        {
        }
        public override IValidator<Planting> GetValidator()
        {
            return new PlantingValidator();
        }
    }
}
