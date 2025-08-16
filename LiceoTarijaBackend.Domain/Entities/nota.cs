using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class Nota
{
    public int IdNota { get; set; }
    public decimal Valor { get; set; }
    public int IdGestionEstudiante { get; set; }
    public int IdEvaluacion { get; set; }
    public DateTime? DeletedAt { get; set; }
    public GestionEstudiante GestionEstudiante { get; set; } = null!;
    public Evaluacion Evaluacion { get; set; } = null!;
}

