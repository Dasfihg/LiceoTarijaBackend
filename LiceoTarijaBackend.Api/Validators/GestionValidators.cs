using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Gestiones;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class GestionCreateValidator : AbstractValidator<GestionCreateDto>
    {
        public GestionCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class GestionUpdateValidator : AbstractValidator<GestionUpdateDto>
    {
        public GestionUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
