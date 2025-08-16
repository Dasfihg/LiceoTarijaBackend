using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class GestionEstudianteCreateValidator : AbstractValidator<GestionEstudianteCreateDto>
    {
        public GestionEstudianteCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }

    public sealed class GestionEstudianteUpdateValidator : AbstractValidator<GestionEstudianteUpdateDto>
    {
        public GestionEstudianteUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }
}





