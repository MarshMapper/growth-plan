using FluentValidation;
using GrowthPlan.Domain.Entities;

namespace GrowthPlan.Application.Validators
{
    class PlantValidator : AbstractValidator<Plant>
    {
        public PlantValidator()
        {
            RuleFor(x => x.CommonName).NotEmpty();
            RuleFor(x => x.CommonName).MaximumLength(200).WithMessage("Common Name must be 200 characters or less");
            RuleFor(x => x.ScientificName).MaximumLength(200).WithMessage("Scientifie Name must be 200 characters or less");
        }
    }
}
