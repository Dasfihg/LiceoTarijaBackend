namespace LiceoTarijaBackend.Application.DTOs.GestionProfesores
{
    public sealed class GestionProfesorCreateDto
    {
            public int IdCursoGestion { get; set; }
            public string Estado { get; set; }
            public bool? EsTutor { get; set; }
            public DateOnly FechaDesde { get; set; }
            public DateOnly? FechaHasta { get; set; }
            public int IdProfesor { get; set; }
    }
}


