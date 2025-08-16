using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Apoderado
{
    public int IdApoderado { get; set; }
    public int IdPersona { get; set; }
    public string Parentesco { get; set; } = null!;
    public int IdDomicilio { get; set; }
    public Persona Persona { get; set; } = null!;
    public Domicilio Domicilio { get; set; } = null!;
    public ICollection<ApoderadoEstudiante> Estudiantes { get; set; } = new List<ApoderadoEstudiante>();
}

