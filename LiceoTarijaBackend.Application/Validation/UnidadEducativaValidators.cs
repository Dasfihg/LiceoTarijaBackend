using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class UnidadEducativaCreateValidator : AbstractValidator<UnidadEducativaCreateDto>
    {
        public UnidadEducativaCreateValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }

    public sealed class UnidadEducativaUpdateValidator : AbstractValidator<UnidadEducativaUpdateDto>
    {
        public UnidadEducativaUpdateValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }
}





