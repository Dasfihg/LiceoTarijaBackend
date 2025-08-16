using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Auditorias;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class AuditoriaCreateValidator : AbstractValidator<AuditoriaCreateDto>
    {
        public AuditoriaCreateValidator()
        {
            RuleFor(x => x.Entidad).NotEmpty();
            RuleFor(x => x.Operacion).NotEmpty();
        }
    }

    public sealed class AuditoriaUpdateValidator : AbstractValidator<AuditoriaUpdateDto>
    {
        public AuditoriaUpdateValidator()
        {
            RuleFor(x => x.Entidad).NotEmpty();
            RuleFor(x => x.Operacion).NotEmpty();
        }
    }
}
