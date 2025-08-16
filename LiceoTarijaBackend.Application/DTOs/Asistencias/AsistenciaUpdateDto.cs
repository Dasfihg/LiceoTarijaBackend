namespace LiceoTarijaBackend.Application.DTOs.Asistencias
{
    public sealed class AsistenciaUpdateDto
    {
            public DateTime? DeletedAt { get; set; }
            public DateOnly Fecha { get; set; }
            public int IdGestionEstudiante { get; set; }
            public string TipoAsistencia { get; set; }
    }
}


