using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.AsignacionHorarias;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class AsignacionHorariaCreateValidator : AbstractValidator<AsignacionHorariaCreateDto>
    {
        public AsignacionHorariaCreateValidator()
        {
            RuleFor(x => x.DiaSemana).NotEmpty();
        }
    }

    public sealed class AsignacionHorariaUpdateValidator : AbstractValidator<AsignacionHorariaUpdateDto>
    {
        public AsignacionHorariaUpdateValidator()
        {
            RuleFor(x => x.DiaSemana).NotEmpty();
        }
    }
}
