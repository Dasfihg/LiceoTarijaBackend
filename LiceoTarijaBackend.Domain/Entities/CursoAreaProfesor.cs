using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class CursoAreaProfesor
{
    public int Id { get; set; }
    public int IdCursoGestion { get; set; }
    public int IdArea { get; set; }
    public int IdProfesor { get; set; }
    public CursoGestion CursoGestion { get; set; } = null!;
    public Area Area { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
}

