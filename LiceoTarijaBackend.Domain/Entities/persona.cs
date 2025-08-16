using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Persona
{
    public int IdPersona { get; set; }
    public string ApellidoPaterno { get; set; } = null!;
    public string ApellidoMaterno { get; set; } = null!;
    public string Nombres { get; set; } = null!;
    public string Cedula { get; set; } = null!;
    public string? Celular { get; set; }
    public string? FotoUrl { get; set; }
    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    public ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
    public ICollection<Personal> Personal { get; set; } = new List<Personal>();
}

