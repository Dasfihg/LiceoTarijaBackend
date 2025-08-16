namespace LiceoTarijaBackend.Application.DTOs.CursosGestion
{
    public sealed class CursoGestionReadDto
    {
        public int IdCursoGestion { get; set; }
        public int IdCurso { get; set; }
        public int IdGestion { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
    }
}



