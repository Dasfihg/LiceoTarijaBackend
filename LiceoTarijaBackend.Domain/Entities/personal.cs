using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Personal
{
    public int IdPersonal { get; set; }
    public int IdPersona { get; set; }
    public string Cargo { get; set; } = null!;
    public Persona Persona { get; set; } = null!;
}

