using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.CursosGestion;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CursoGestionCreateValidator : AbstractValidator<CursoGestionCreateDto>
    {
        public CursoGestionCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class CursoGestionUpdateValidator : AbstractValidator<CursoGestionUpdateDto>
    {
        public CursoGestionUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}

