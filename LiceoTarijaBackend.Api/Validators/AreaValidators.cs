using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Areas;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class AreaCreateValidator : AbstractValidator<AreaCreateDto>
    {
        public AreaCreateValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }

    public sealed class AreaUpdateValidator : AbstractValidator<AreaUpdateDto>
    {
        public AreaUpdateValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }
}
