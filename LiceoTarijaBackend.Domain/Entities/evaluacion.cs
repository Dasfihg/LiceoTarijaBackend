using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Evaluacion
{
    public int IdEvaluacion { get; set; }
    public DateOnly Fecha { get; set; }
    public string Descripcion { get; set; } = null!;
    public int IdDimension { get; set; }
    public int IdArea { get; set; }
    public int IdProfesor { get; set; }
    public int IdPeriodo { get; set; }
    public int IdCursoGestion { get; set; }
    public string TipoEvaluacion { get; set; } = null!;
    public int? CreadoPorUsuarioId { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Dimension Dimension { get; set; } = null!;
    public Area Area { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
    public Periodo Periodo { get; set; } = null!;
    public CursoGestion CursoGestion { get; set; } = null!;
    public Usuario? CreadoPor { get; set; }
    public ICollection<Nota> Notas { get; set; } = new List<Nota>();
}

