using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class GestionEstudiante
{
    public int IdGestionEstudiante { get; set; }
    public int IdEstudiante { get; set; }
    public int IdCursoGestion { get; set; }
    public DateOnly FechaInscripcion { get; set; }
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public string Estado { get; set; } = null!;
    public Estudiante Estudiante { get; set; } = null!;
    public CursoGestion CursoGestion { get; set; } = null!;
    public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    public ICollection<Asistencia> Asistencias { get; set; } = new List<Asistencia>();
    public ICollection<Observacion> Observaciones { get; set; } = new List<Observacion>();
}

