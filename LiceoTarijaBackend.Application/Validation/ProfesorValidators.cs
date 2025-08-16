using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class ProfesorCreateValidator : AbstractValidator<ProfesorCreateDto>
    {
        public ProfesorCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }

    public sealed class ProfesorUpdateValidator : AbstractValidator<ProfesorUpdateDto>
    {
        public ProfesorUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }
}





