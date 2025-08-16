using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Auditoria
{
    public int Id { get; set; }
    public string Entidad { get; set; } = null!;
    public int EntidadId { get; set; }
    public string? Columna { get; set; }
    public int? UsuarioId { get; set; }
    public string Operacion { get; set; } = null!;
    public string? ValorAnterior { get; set; }
    public string? ValorNuevo { get; set; }
    public string? Observacion { get; set; }
    public DateTime FechaCambio { get; set; }
}

