using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class CursoGestion
{
    public int IdCursoGestion { get; set; }
    public int IdCurso { get; set; }
    public int IdGestion { get; set; }
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public Curso Curso { get; set; } = null!;
    public Gestion Gestion { get; set; } = null!;
    public ICollection<CursoArea> CursosAreas { get; set; } = new List<CursoArea>();
    public ICollection<CursoAreaProfesor> CursosAreasProfesores { get; set; } = new List<CursoAreaProfesor>();
    public ICollection<GestionEstudiante> Estudiantes { get; set; } = new List<GestionEstudiante>();
    public ICollection<GestionProfesor> Profesores { get; set; } = new List<GestionProfesor>();
    public ICollection<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    public ICollection<AsignacionHoraria> Asignaciones { get; set; } = new List<AsignacionHoraria>();
}

