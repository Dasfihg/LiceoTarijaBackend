namespace LiceoTarijaBackend.Application.DTOs.CalificacionesExcepciones
{
    public sealed class CalificacionesExcepcionReadDto
    {
            public DateTime FechaDesde { get; set; }
            public DateTime? FechaHasta { get; set; }
            public int IdExcepcion { get; set; }
            public int IdVentana { get; set; }
            public string Motivo { get; set; } = string.Empty;
            public int UsuarioId { get; set; }
    }
}




