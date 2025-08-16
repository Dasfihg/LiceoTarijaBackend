using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Periodo
{
    public int IdPeriodo { get; set; }
    public string Nombre { get; set; } = null!;
    public string Codigo { get; set; } = null!;
    public int Orden { get; set; }
    public DateOnly? FechaInicio { get; set; }
    public DateOnly? FechaFin { get; set; }
    public ICollection<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    public ICollection<CalificacionesVentana> CalificacionesVentanas { get; set; } = new List<CalificacionesVentana>();
}

