using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class UsuarioRol
{
    public int IdUsuario { get; set; }
    public string Rol { get; set; } = null!;
    public DateOnly FechaDesde { get; set; }
    public DateOnly? FechaHasta { get; set; }
    public Usuario Usuario { get; set; } = null!;
}

