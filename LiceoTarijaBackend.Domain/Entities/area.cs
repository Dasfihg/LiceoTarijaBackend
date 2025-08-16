using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Area
{
    public int IdArea { get; set; }
    public string Codigo { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public ICollection<CursoArea> CursosAreas { get; set; } = new List<CursoArea>();
    public ICollection<CursoAreaProfesor> CursosAreasProfesores { get; set; } = new List<CursoAreaProfesor>();
    public ICollection<Observacion> Observaciones { get; set; } = new List<Observacion>();
    public ICollection<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
}

