using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Asistencia
{
    public int IdAsistencia { get; set; }
    public int IdGestionEstudiante { get; set; }
    public DateOnly Fecha { get; set; }
    public string TipoAsistencia { get; set; } = null!;
    public DateTime? DeletedAt { get; set; }
    public GestionEstudiante GestionEstudiante { get; set; } = null!;
}

