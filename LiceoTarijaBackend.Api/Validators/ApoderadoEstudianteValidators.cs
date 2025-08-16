using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.ApoderadoEstudiantes;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class ApoderadoEstudianteCreateValidator : AbstractValidator<ApoderadoEstudianteCreateDto>
    {
        public ApoderadoEstudianteCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class ApoderadoEstudianteUpdateValidator : AbstractValidator<ApoderadoEstudianteUpdateDto>
    {
        public ApoderadoEstudianteUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
