namespace LiceoTarijaBackend.Application.DTOs.Periodos
{
    public sealed class PeriodoReadDto
    {
            public string Codigo { get; set; }
            public DateOnly? FechaFin { get; set; }
            public DateOnly? FechaInicio { get; set; }
            public int IdPeriodo { get; set; }
            public string Nombre { get; set; }
            public int Orden { get; set; }
    }
}


