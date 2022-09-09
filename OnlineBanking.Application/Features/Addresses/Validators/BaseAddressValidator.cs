using FluentValidation;
using OnlineBanking.Application.Models.Address.Base;

namespace OnlineBanking.Application.Features.Addresses.Validators;

public class BaseAddressValidator : AbstractValidator<BaseAddressDto>
{
    public BaseAddressValidator()
    {
        RuleFor(c => c.Name)
        .NotNull().WithMessage("{PropertyName} is required")
        .NotEmpty().WithMessage("{PropertyName} is required");

        RuleFor(c => c.DistrictId)
        .NotNull().WithMessage("{PropertyName} is required")
        .NotEmpty().WithMessage("{PropertyName} is required");

        RuleFor(c => c.CityId)
        .NotNull().WithMessage("{PropertyName} is required")
        .NotEmpty().WithMessage("{PropertyName} is required");

        
        RuleFor(c => c.CountryId)
        .NotNull().WithMessage("{PropertyName} is required")
        .NotEmpty().WithMessage("{PropertyName} is required");
    }
}