using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class EvaluacionCreateValidator : AbstractValidator<EvaluacionCreateDto>
    {
        public EvaluacionCreateValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty();
            RuleFor(x => x.TipoEvaluacion).NotEmpty();
        }
    }

    public sealed class EvaluacionUpdateValidator : AbstractValidator<EvaluacionUpdateDto>
    {
        public EvaluacionUpdateValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty();
            RuleFor(x => x.TipoEvaluacion).NotEmpty();
        }
    }
}





