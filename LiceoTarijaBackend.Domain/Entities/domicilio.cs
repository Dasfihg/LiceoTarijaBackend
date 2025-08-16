using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Domicilio
{
    public int IdDomicilio { get; set; }
    public string? Zona { get; set; }
    public string? Calle { get; set; }
    public string? Numero { get; set; }
    public string? TelefonoFijo { get; set; }
    public ICollection<Apoderado> Apoderados { get; set; } = new List<Apoderado>();
    public ICollection<UnidadEducativa> UnidadesEducativas { get; set; } = new List<UnidadEducativa>();
}

