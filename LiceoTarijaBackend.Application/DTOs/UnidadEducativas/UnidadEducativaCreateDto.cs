namespace LiceoTarijaBackend.Application.DTOs.UnidadEducativas
{
    public sealed class UnidadEducativaCreateDto
    {
            public string Codigo { get; set; }
            public DateTime CreatedAt { get; set; }
            public int? DomicilioId { get; set; }
            public string Email { get; set; }
            public string LogoUrl { get; set; }
            public string Nombre { get; set; }
            public string Sigla { get; set; }
            public string SitioWeb { get; set; }
            public string Telefono1 { get; set; }
            public string Telefono2 { get; set; }
            public DateTime? UpdatedAt { get; set; }
    }
}


