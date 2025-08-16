namespace LiceoTarijaBackend.Application.DTOs.Usuarios
{
    public sealed class UsuarioUpdateDto
    {
            public string Estado { get; set; }
            public int IdPersona { get; set; }
            public string NombreUsuario { get; set; }
            public string PasswordHash { get; set; }
    }
}


