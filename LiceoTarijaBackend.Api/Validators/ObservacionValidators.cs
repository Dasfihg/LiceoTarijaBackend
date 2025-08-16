using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Observaciones;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class ObservacionCreateValidator : AbstractValidator<ObservacionCreateDto>
    {
        public ObservacionCreateValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty();
        }
    }

    public sealed class ObservacionUpdateValidator : AbstractValidator<ObservacionUpdateDto>
    {
        public ObservacionUpdateValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty();
        }
    }
}
