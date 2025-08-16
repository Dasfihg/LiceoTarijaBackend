using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class GestionProfesorCreateValidator : AbstractValidator<GestionProfesorCreateDto>
    {
        public GestionProfesorCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }

    public sealed class GestionProfesorUpdateValidator : AbstractValidator<GestionProfesorUpdateDto>
    {
        public GestionProfesorUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }
}





