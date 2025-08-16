using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Personal;

namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class PersonalCreateValidator : AbstractValidator<PersonalCreateDto>
    {
        public PersonalCreateValidator()
        {
            RuleFor(x => x.Cargo).NotEmpty();
        }
    }

    public sealed class PersonalUpdateValidator : AbstractValidator<PersonalUpdateDto>
    {
        public PersonalUpdateValidator()
        {
            RuleFor(x => x.Cargo).NotEmpty();
        }
    }
}





