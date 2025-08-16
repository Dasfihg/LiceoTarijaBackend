using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class AsignacionHoraria
{
    public int Id { get; set; }
    public int IdCursoGestion { get; set; }
    public int IdArea { get; set; }
    public int IdProfesor { get; set; }
    public string DiaSemana { get; set; } = null!;
    public int IdBloque { get; set; }
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public Area Area { get; set; } = null!;
    public BloqueHorario Bloque { get; set; } = null!;
    public CursoGestion CursoGestion { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
}

