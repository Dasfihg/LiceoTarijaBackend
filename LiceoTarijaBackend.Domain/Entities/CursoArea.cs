using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class CursoArea
{
    public int IdCursoArea { get; set; }
    public int IdCursoGestion { get; set; }
    public int IdArea { get; set; }
    public CursoGestion CursoGestion { get; set; } = null!;
    public Area Area { get; set; } = null!;
}

