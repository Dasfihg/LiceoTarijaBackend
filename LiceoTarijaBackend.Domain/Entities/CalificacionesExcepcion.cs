using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class CalificacionesExcepcion
{
    public int IdExcepcion { get; set; }
    public int IdVentana { get; set; }
    public int UsuarioId { get; set; }
    public string? Motivo { get; set; }
    public DateTime FechaDesde { get; set; }
    public DateTime? FechaHasta { get; set; }
    public CalificacionesVentana Ventana { get; set; } = null!;
    public Usuario Usuario { get; set; } = null!;
}

