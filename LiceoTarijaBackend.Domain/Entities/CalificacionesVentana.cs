using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class CalificacionesVentana
{
    public int IdVentana { get; set; }
    public int IdGestion { get; set; }
    public int IdPeriodo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string Estado { get; set; } = null!;
    public int? AbiertoPorUsuarioId { get; set; }
    public DateTime? AbiertoEn { get; set; }
    public int? CerradoPorUsuarioId { get; set; }
    public DateTime? CerradoEn { get; set; }
    public Gestion Gestion { get; set; } = null!;
    public Periodo Periodo { get; set; } = null!;
    public Usuario? AbiertoPor { get; set; }
    public Usuario? CerradoPor { get; set; }
    public ICollection<CalificacionesExcepcion> Excepciones { get; set; } = new List<CalificacionesExcepcion>();
}

