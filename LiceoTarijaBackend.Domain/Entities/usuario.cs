using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Usuario
{
    public int IdUsuario { get; set; }
    public int IdPersona { get; set; }
    public string NombreUsuario { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public Persona Persona { get; set; } = null!;
    public ICollection<UsuarioRol> Roles { get; set; } = new List<UsuarioRol>();
    public ICollection<Evaluacion> EvaluacionesCreadas { get; set; } = new List<Evaluacion>();
    public ICollection<Observacion> ObservacionesCreadas { get; set; } = new List<Observacion>();
    public ICollection<CalificacionesVentana> CalificacionesVentanasAbiertas { get; set; } = new List<CalificacionesVentana>();
    public ICollection<CalificacionesVentana> CalificacionesVentanasCerradas { get; set; } = new List<CalificacionesVentana>();
    public ICollection<CalificacionesExcepcion> CalificacionesExcepciones { get; set; } = new List<CalificacionesExcepcion>();
}

