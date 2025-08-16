namespace LiceoTarijaBackend.Application.DTOs.BloqueHorarios
{
    public sealed class BloqueHorarioCreateDto
    {
            public int Bloque { get; set; }
            public int IdGestion { get; set; }
            public TimeOnly HoraFin { get; set; }
            public TimeOnly HoraInicio { get; set; }
    }
}


