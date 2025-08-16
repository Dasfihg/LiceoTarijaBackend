namespace LiceoTarijaBackend.Application.DTOs.GestionEstudiantes
{
    public sealed class GestionEstudianteReadDto
    {
            public int IdCursoGestion { get; set; }
            public string Estado { get; set; }
            public int IdEstudiante { get; set; }
            public DateOnly FechaDesde { get; set; }
            public DateOnly? FechaHasta { get; set; }
            public DateOnly FechaInscripcion { get; set; }
            public int IdGestionEstudiante { get; set; }
    }
}


