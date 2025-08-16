namespace LiceoTarijaBackend.Application.DTOs.Estudiantes
{
    public sealed class EstudianteCreateDto
    {
            public string Estado { get; set; }
            public DateOnly? FechaNacimiento { get; set; }
            public int IdPersona { get; set; }
            public string Rude { get; set; }
            public string Sexo { get; set; }
    }
}


