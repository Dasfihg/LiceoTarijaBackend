using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class EstudianteCreateValidator : AbstractValidator<EstudianteCreateDto>
    {
        public EstudianteCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
            RuleFor(x => x.Rude).NotEmpty();
            RuleFor(x => x.Sexo).NotEmpty();
        }
    }

    public sealed class EstudianteUpdateValidator : AbstractValidator<EstudianteUpdateDto>
    {
        public EstudianteUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
            RuleFor(x => x.Rude).NotEmpty();
            RuleFor(x => x.Sexo).NotEmpty();
        }
    }
}





