using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Curso
{
    public int IdCurso { get; set; }
    public string Nivel { get; set; } = null!;
    public string Grado { get; set; } = null!;
    public string Paralelo { get; set; } = null!;
    public ICollection<CursoGestion> Gestiones { get; set; } = new List<CursoGestion>();
}

