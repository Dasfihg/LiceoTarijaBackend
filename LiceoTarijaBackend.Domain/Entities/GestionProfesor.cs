using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class GestionProfesor
{
    public int IdGestionProfesor { get; set; }
    public int IdProfesor { get; set; }
    public int IdCursoGestion { get; set; }
    public bool? EsTutor { get; set; }
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public string Estado { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
    public CursoGestion CursoGestion { get; set; } = null!;
}

