namespace LiceoTarijaBackend.Application.DTOs.Notas
{
    public sealed class NotaCreateDto
    {
        public int IdGestionEstudiante { get; set; }
        public int IdEvaluacion { get; set; }
        public decimal Valor { get; set; }
    }
}



