using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Profesor
{
    public int IdProfesor { get; set; }
    public int IdPersona { get; set; }
    public int Rda { get; set; }
    public string Estado { get; set; } = null!;
    public Persona Persona { get; set; } = null!;
    public ICollection<CursoAreaProfesor> CursosAreas { get; set; } = new List<CursoAreaProfesor>();
    public ICollection<GestionProfesor> Gestiones { get; set; } = new List<GestionProfesor>();
    public ICollection<Observacion> Observaciones { get; set; } = new List<Observacion>();
    public ICollection<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
}

