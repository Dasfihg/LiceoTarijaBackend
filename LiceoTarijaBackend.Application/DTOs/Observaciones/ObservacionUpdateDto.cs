namespace LiceoTarijaBackend.Application.DTOs.Observaciones
{
    public sealed class ObservacionUpdateDto
    {
            public int IdArea { get; set; }
            public int? CreadoPorUsuarioId { get; set; }
            public DateTime? DeletedAt { get; set; }
            public string Descripcion { get; set; }
            public DateOnly Fecha { get; set; }
            public int IdGestionEstudiante { get; set; }
            public int IdProfesor { get; set; }
    }
}



