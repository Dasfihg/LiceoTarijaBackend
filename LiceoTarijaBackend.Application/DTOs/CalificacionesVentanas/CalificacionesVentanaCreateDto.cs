namespace LiceoTarijaBackend.Application.DTOs.CalificacionesVentanas
{
    public sealed class CalificacionesVentanaCreateDto
    {
        public int IdGestion { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Estado { get; set; } // null -> "abierta"
    }
}



