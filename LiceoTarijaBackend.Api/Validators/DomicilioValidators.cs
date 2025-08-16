using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Domicilios;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class DomicilioCreateValidator : AbstractValidator<DomicilioCreateDto>
    {
        public DomicilioCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class DomicilioUpdateValidator : AbstractValidator<DomicilioUpdateDto>
    {
        public DomicilioUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
