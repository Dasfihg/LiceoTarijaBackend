using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Dimension
{
    public int IdDimension { get; set; }
    public string Nombre { get; set; } = null!;
    public int Peso { get; set; }
    public ICollection<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
}

