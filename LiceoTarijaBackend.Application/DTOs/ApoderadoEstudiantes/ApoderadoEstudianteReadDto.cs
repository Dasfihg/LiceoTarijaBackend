namespace LiceoTarijaBackend.Application.DTOs.ApoderadoEstudiantes
{
    public sealed class ApoderadoEstudianteReadDto
    {
        public int IdApoderado { get; set; }
        public int IdEstudiante { get; set; }
        public bool Titular { get; set; }
        public DateOnly FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
    }
}



