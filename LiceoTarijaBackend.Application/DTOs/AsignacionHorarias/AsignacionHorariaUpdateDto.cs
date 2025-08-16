namespace LiceoTarijaBackend.Application.DTOs.AsignacionHorarias
{
    public sealed class AsignacionHorariaUpdateDto
    {
            public int IdArea { get; set; }
            public int IdBloque { get; set; }
            public int IdCursoGestion { get; set; }
            public string DiaSemana { get; set; }
            public DateOnly FechaDesde { get; set; }
            public DateOnly? FechaHasta { get; set; }
            public int IdProfesor { get; set; }
    }
}


