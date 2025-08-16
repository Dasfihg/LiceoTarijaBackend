using System;
using System.Collections.Generic;

namespace LiceoTarijaBackend.Domain.Entities;

public class UnidadEducativa
{
    public int IdUnidad { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Sigla { get; set; }
    public string? Codigo { get; set; }
    public int? DomicilioId { get; set; }
    public string? Telefono1 { get; set; }
    public string? Telefono2 { get; set; }
    public string? Email { get; set; }
    public string? SitioWeb { get; set; }
    public string? LogoUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Domicilio? Domicilio { get; set; }
}

