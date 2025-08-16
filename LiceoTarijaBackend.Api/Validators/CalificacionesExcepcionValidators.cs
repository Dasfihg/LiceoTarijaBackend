using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.CalificacionesExcepciones;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CalificacionesExcepcionCreateValidator : AbstractValidator<CalificacionesExcepcionCreateDto>
    {
        public CalificacionesExcepcionCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class CalificacionesExcepcionUpdateValidator : AbstractValidator<CalificacionesExcepcionUpdateDto>
    {
        public CalificacionesExcepcionUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
