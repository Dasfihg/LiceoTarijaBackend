namespace LiceoTarijaBackend.Application.DTOs.ApoderadoEstudiantes
{
    public sealed class ApoderadoEstudianteCreateDto
    {
        public int IdApoderado { get; set; }
        public int IdEstudiante { get; set; }
        public bool Titular { get; set; } = false;
        public DateOnly? FechaDesde { get; set; } // si es null, el backend pone hoy()
    }
}



