namespace LiceoTarijaBackend.Application.DTOs.Usuarios
{
    public sealed class UsuarioReadDto
    {
            public string Estado { get; set; }
            public int IdPersona { get; set; }
            public int IdUsuario { get; set; }
            public string NombreUsuario { get; set; }
            public string PasswordHash { get; set; }
    }
}


