namespace LiceoTarijaBackend.Application.DTOs.Auditorias
{
    public sealed class AuditoriaUpdateDto
    {
            public string Columna { get; set; }
            public string Entidad { get; set; }
            public int EntidadId { get; set; }
            public DateTime FechaCambio { get; set; }
            public string Observacion { get; set; }
            public string Operacion { get; set; }
            public int? UsuarioId { get; set; }
            public string ValorAnterior { get; set; }
            public string ValorNuevo { get; set; }
    }
}


