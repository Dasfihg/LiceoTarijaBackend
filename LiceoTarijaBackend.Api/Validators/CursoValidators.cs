using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Cursos;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class CursoCreateValidator : AbstractValidator<CursoCreateDto>
    {
        public CursoCreateValidator()
        {
            RuleFor(x => x.Grado).NotEmpty();
            RuleFor(x => x.Nivel).NotEmpty();
            RuleFor(x => x.Paralelo).NotEmpty();
        }
    }

    public sealed class CursoUpdateValidator : AbstractValidator<CursoUpdateDto>
    {
        public CursoUpdateValidator()
        {
            RuleFor(x => x.Grado).NotEmpty();
            RuleFor(x => x.Nivel).NotEmpty();
            RuleFor(x => x.Paralelo).NotEmpty();
        }
    }
}
