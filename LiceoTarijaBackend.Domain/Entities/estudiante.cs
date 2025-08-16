using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Estudiante
{
    public int IdEstudiante { get; set; }
    public int IdPersona { get; set; }
    public DateOnly? FechaNacimiento { get; set; }
    public string Sexo { get; set; } = null!;
    public string Rude { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public Persona Persona { get; set; } = null!;
    public ICollection<ApoderadoEstudiante> Apoderados { get; set; } = new List<ApoderadoEstudiante>();
    public ICollection<GestionEstudiante> Gestiones { get; set; } = new List<GestionEstudiante>();
}

