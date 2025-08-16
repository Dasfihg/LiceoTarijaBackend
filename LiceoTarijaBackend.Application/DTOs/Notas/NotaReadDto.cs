namespace LiceoTarijaBackend.Application.DTOs.Notas
{
    public sealed class NotaReadDto
    {
        public int IdNota { get; set; }
        public decimal Valor { get; set; }
        public int IdGestionEstudiante { get; set; }
        public int IdEvaluacion { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}



