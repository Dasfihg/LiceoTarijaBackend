using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class AsistenciaCreateValidator : AbstractValidator<AsistenciaCreateDto>
    {
        public AsistenciaCreateValidator()
        {
            RuleFor(x => x.TipoAsistencia).NotEmpty();
        }
    }

    public sealed class AsistenciaUpdateValidator : AbstractValidator<AsistenciaUpdateDto>
    {
        public AsistenciaUpdateValidator()
        {
            RuleFor(x => x.TipoAsistencia).NotEmpty();
        }
    }
}





