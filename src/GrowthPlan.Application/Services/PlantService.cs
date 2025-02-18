using FluentValidation;
using GrowthPlan.Application.Interfaces;
using GrowthPlan.Application.Validators;
using GrowthPlan.Domain.Entities;

namespace GrowthPlan.Application.Services
{
    public class PlantService : CrudService<Plant>, IPlantService
    {
        public PlantService(IRepository<Plant> repository) : base(repository)
        {
        }
        public override IValidator<Plant> GetValidator()
        {
            return new PlantValidator();
        }
    }
}
