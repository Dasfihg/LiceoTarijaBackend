namespace LiceoTarijaBackend.Application.DTOs.Gestiones
{
    public sealed class GestionReadDto
    {
            public int Anio { get; set; }
            public DateOnly FechaFin { get; set; }
            public DateOnly FechaInicio { get; set; }
            public int IdGestion { get; set; }
    }
}


