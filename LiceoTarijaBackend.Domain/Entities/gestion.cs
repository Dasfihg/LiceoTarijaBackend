using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Gestion
{
    public int IdGestion { get; set; }
    public int Anio { get; set; }
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }
    public ICollection<CursoGestion> Cursos { get; set; } = new List<CursoGestion>();
    public ICollection<BloqueHorario> Bloques { get; set; } = new List<BloqueHorario>();
    public ICollection<CalificacionesVentana> CalificacionesVentanas { get; set; } = new List<CalificacionesVentana>();
}

