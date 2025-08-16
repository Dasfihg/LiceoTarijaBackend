using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.BloqueHorarios;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class BloqueHorarioCreateValidator : AbstractValidator<BloqueHorarioCreateDto>
    {
        public BloqueHorarioCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class BloqueHorarioUpdateValidator : AbstractValidator<BloqueHorarioUpdateDto>
    {
        public BloqueHorarioUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
