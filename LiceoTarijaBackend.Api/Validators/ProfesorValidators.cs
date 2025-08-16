using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Profesores;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class ProfesorCreateValidator : AbstractValidator<ProfesorCreateDto>
    {
        public ProfesorCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }

    public sealed class ProfesorUpdateValidator : AbstractValidator<ProfesorUpdateDto>
    {
        public ProfesorUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
        }
    }
}
