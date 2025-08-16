using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Observacion
{
    public int IdObservacion { get; set; }
    public int IdGestionEstudiante { get; set; }
    public int IdProfesor { get; set; }
    public int IdArea { get; set; }
    public DateOnly Fecha { get; set; }
    public string Descripcion { get; set; } = null!;
    public int? CreadoPorUsuarioId { get; set; }
    public DateTime? DeletedAt { get; set; }
    public GestionEstudiante GestionEstudiante { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
    public Area Area { get; set; } = null!;
    public Usuario? CreadoPor { get; set; }
}

