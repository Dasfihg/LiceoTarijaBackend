using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.CursoAreaProfesores;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CursoAreaProfesorCreateValidator : AbstractValidator<CursoAreaProfesorCreateDto>
    {
        public CursoAreaProfesorCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class CursoAreaProfesorUpdateValidator : AbstractValidator<CursoAreaProfesorUpdateDto>
    {
        public CursoAreaProfesorUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
