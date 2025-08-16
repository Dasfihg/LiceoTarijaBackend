using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.CalificacionesVentanas;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CalificacionesVentanaCreateValidator : AbstractValidator<CalificacionesVentanaCreateDto>
    {
        public CalificacionesVentanaCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }

    public sealed class CalificacionesVentanaUpdateValidator : AbstractValidator<CalificacionesVentanaUpdateDto>
    {
        public CalificacionesVentanaUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }
}
