using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.UsuariosRoles;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class UsuarioRolCreateValidator : AbstractValidator<UsuarioRolCreateDto>
    {
        public UsuarioRolCreateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }

    public sealed class UsuarioRolUpdateValidator : AbstractValidator<UsuarioRolUpdateDto>
    {
        public UsuarioRolUpdateValidator()
        {
                // TODO: reglas especÃ­ficas
        }
    }
}
