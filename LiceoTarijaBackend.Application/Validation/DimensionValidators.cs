using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
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





