namespace LiceoTarijaBackend.Application.DTOs.CalificacionesVentanas
{
    public sealed class CalificacionesVentanaReadDto
    {
        public int IdVentana { get; set; }
        public int IdGestion { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = default!;
    }
}



