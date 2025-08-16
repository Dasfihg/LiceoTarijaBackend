using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Apoderados;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class ApoderadoCreateValidator : AbstractValidator<ApoderadoCreateDto>
    {
        public ApoderadoCreateValidator()
        {
            RuleFor(x => x.Parentesco).NotEmpty();
        }
    }

    public sealed class ApoderadoUpdateValidator : AbstractValidator<ApoderadoUpdateDto>
    {
        public ApoderadoUpdateValidator()
        {
            RuleFor(x => x.Parentesco).NotEmpty();
        }
    }
}
