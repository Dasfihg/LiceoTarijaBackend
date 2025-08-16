using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class BloqueHorario
{
    public int IdBloque { get; set; }
    public int IdGestion { get; set; }
    public int Bloque { get; set; }
    public TimeOnly HoraInicio { get; set; }
    public TimeOnly HoraFin { get; set; }
    public Gestion Gestion { get; set; } = null!;
    public ICollection<AsignacionHoraria> Asignaciones { get; set; } = new List<AsignacionHoraria>();
}

