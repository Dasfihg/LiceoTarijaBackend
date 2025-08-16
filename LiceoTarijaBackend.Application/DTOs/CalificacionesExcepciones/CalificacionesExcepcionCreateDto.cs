namespace LiceoTarijaBackend.Application.DTOs.CalificacionesExcepciones
{
    public sealed class CalificacionesExcepcionCreateDto
    {
            public DateTime FechaDesde { get; set; }
            public DateTime? FechaHasta { get; set; }
            public int IdVentana { get; set; }
            public string Motivo { get; set; } = string.Empty;
            public int UsuarioId { get; set; }
    }
}




