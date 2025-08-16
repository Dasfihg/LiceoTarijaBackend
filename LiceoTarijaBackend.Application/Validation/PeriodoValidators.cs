using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class PeriodoCreateValidator : AbstractValidator<PeriodoCreateDto>
    {
        public PeriodoCreateValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }

    public sealed class PeriodoUpdateValidator : AbstractValidator<PeriodoUpdateDto>
    {
        public PeriodoUpdateValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }
}





