namespace LiceoTarijaBackend.Application.DTOs.Gestiones
{
    public sealed class GestionUpdateDto
    {
            public int Anio { get; set; }
            public DateOnly FechaFin { get; set; }
            public DateOnly FechaInicio { get; set; }
    }
}


