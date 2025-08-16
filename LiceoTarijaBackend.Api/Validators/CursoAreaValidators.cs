using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.CursoAreas;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CursoAreaCreateValidator : AbstractValidator<CursoAreaCreateDto>
    {
        public CursoAreaCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class CursoAreaUpdateValidator : AbstractValidator<CursoAreaUpdateDto>
    {
        public CursoAreaUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
