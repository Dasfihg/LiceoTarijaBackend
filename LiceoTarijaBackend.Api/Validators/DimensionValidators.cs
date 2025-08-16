using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Dimensions;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class DimensionCreateValidator : AbstractValidator<DimensionCreateDto>
    {
        public DimensionCreateValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }

    public sealed class DimensionUpdateValidator : AbstractValidator<DimensionUpdateDto>
    {
        public DimensionUpdateValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }
}
