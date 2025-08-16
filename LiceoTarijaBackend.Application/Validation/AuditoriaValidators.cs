using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
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





