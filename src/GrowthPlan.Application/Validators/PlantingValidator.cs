using FluentValidation;
using GrowthPlan.Domain.Entities;

namespace GrowthPlan.Application.Validators
{
    class PlantingValidator : AbstractValidator<Planting>
    {
        public PlantingValidator()
        {
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Description must be 500 characters or less");
        }
    }
}
