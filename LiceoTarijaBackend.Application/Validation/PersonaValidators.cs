using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class PersonaCreateValidator : AbstractValidator<PersonaCreateDto>
    {
        public PersonaCreateValidator()
        {
            RuleFor(x => x.ApellidoMaterno).NotEmpty();
            RuleFor(x => x.ApellidoPaterno).NotEmpty();
            RuleFor(x => x.Cedula).NotEmpty();
            RuleFor(x => x.Nombres).NotEmpty();
        }
    }

    public sealed class PersonaUpdateValidator : AbstractValidator<PersonaUpdateDto>
    {
        public PersonaUpdateValidator()
        {
            RuleFor(x => x.ApellidoMaterno).NotEmpty();
            RuleFor(x => x.ApellidoPaterno).NotEmpty();
            RuleFor(x => x.Cedula).NotEmpty();
            RuleFor(x => x.Nombres).NotEmpty();
        }
    }
}





