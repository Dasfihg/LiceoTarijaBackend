namespace LiceoTarijaBackend.Application.DTOs.UsuariosRoles
{
    public sealed class UsuarioRolReadDto
    {
            public DateOnly FechaDesde { get; set; }
            public DateOnly? FechaHasta { get; set; }
            public int IdUsuario { get; set; }
            public string Rol { get; set; }
    }
}



