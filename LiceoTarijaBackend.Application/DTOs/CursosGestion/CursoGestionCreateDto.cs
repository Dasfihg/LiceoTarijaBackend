namespace LiceoTarijaBackend.Application.DTOs.CursosGestion
{
    public sealed class CursoGestionCreateDto
    {
        public int IdCurso { get; set; }
        public int IdGestion { get; set; }
        public DateOnly? FechaDesde { get; set; } 
        public DateOnly? FechaHasta { get; set; }
    }
}



