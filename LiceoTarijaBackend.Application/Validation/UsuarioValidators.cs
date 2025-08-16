using FluentValidation;
namespace LiceoTarijaBackend.Application.Validators
{
    public sealed class UsuarioCreateValidator : AbstractValidator<UsuarioCreateDto>
    {
        public UsuarioCreateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
            RuleFor(x => x.NombreUsuario).NotEmpty();
            RuleFor(x => x.PasswordHash).NotEmpty();
        }
    }

    public sealed class UsuarioUpdateValidator : AbstractValidator<UsuarioUpdateDto>
    {
        public UsuarioUpdateValidator()
        {
            RuleFor(x => x.Estado).NotEmpty();
            RuleFor(x => x.NombreUsuario).NotEmpty();
            RuleFor(x => x.PasswordHash).NotEmpty();
        }
    }
}





