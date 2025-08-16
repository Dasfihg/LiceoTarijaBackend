using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class ApoderadoEstudiante
{
    public int IdApoderado { get; set; }
    public int IdEstudiante { get; set; }
    public bool? Titular { get; set; }
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public Apoderado Apoderado { get; set; } = null!;
    public Estudiante Estudiante { get; set; } = null!;
}

