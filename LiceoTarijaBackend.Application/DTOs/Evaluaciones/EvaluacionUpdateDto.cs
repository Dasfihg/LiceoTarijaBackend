namespace LiceoTarijaBackend.Application.DTOs.Evaluaciones
{
    public sealed class EvaluacionUpdateDto
    {
            public int IdArea { get; set; }
            public int? CreadoPorUsuarioId { get; set; }
            public int IdCursoGestion { get; set; }
            public DateTime? DeletedAt { get; set; }
            public string Descripcion { get; set; }
            public int IdDimension { get; set; }
            public DateOnly Fecha { get; set; }
            public int IdPeriodo { get; set; }
            public int IdProfesor { get; set; }
            public string TipoEvaluacion { get; set; }
    }
}



