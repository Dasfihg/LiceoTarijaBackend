namespace LiceoTarijaBackend.Application.DTOs.Estudiantes
{
    public sealed class EstudianteReadDto
    {
            public string Estado { get; set; }
            public DateOnly? FechaNacimiento { get; set; }
            public int IdEstudiante { get; set; }
            public int IdPersona { get; set; }
            public string Rude { get; set; }
            public string Sexo { get; set; }
    }
}


