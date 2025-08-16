using System.Linq;
using FluentValidation;
using LiceoTarijaBackend.Application.DTOs.Notas;
using LiceoTarijaBackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LiceoTarijaBackend.Infrastructure.Validators
{
    public sealed class NotaCreateValidator : AbstractValidator<NotaCreateDto>
    {
        private readonly LiceoTarijaDbContext _db;

        public NotaCreateValidator(LiceoTarijaDbContext db)
        {
            _db = db;

            // 1) Rango permitido
            RuleFor(x => x.Valor)
                .InclusiveBetween(0m, 100m)
                .WithMessage("La nota debe estar entre 0 y 100.");

            // 2) FKs válidos
            RuleFor(x => x.IdGestionEstudiante)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await _db.GestionesEstudiantes.AsNoTracking().AnyAsync(g => g.IdGestionEstudiante == id, ct))
                .WithMessage("Gestión-Estudiante inexistente.");

            RuleFor(x => x.IdEvaluacion)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await _db.Evaluaciones.AsNoTracking().AnyAsync(e => e.IdEvaluacion == id, ct))
                .WithMessage("Evaluación inexistente.");

            // 3) Evitar duplicados (misma evaluación para el mismo estudiante)
            RuleFor(x => x)
                .MustAsync(async (dto, ct) =>
                    !await _db.Notas.AsNoTracking().AnyAsync(n =>
                        n.IdGestionEstudiante == dto.IdGestionEstudiante &&
                        n.IdEvaluacion == dto.IdEvaluacion &&
                        n.DeletedAt == null, ct))
                .WithMessage("Ya existe una nota para ese estudiante en esa evaluación.");

            // 4) Ventana de calificación abierta (o excepción activa)
            RuleFor(x => x.IdEvaluacion)
                .MustAsync(async (idEval, ct) =>
                {
                    var eval = await _db.Evaluaciones
                        .AsNoTracking()
                        .FirstOrDefaultAsync(e => e.IdEvaluacion == idEval, ct);
                    if (eval is null) return false;

                    // gestión de la evaluación
                    var gestionId = await _db.CursosGestion
                        .AsNoTracking()
                        .Where(cg => cg.IdCursoGestion == eval.IdCursoGestion)
                        .Select(cg => cg.IdGestion)
                        .FirstOrDefaultAsync(ct);

                    var ventana = await _db.CalificacionesVentanas
                        .AsNoTracking()
                        .FirstOrDefaultAsync(v => v.IdGestion == gestionId && v.IdPeriodo == eval.IdPeriodo, ct);

                    if (ventana is null) return false;

                    var now = DateTime.UtcNow;
                    var abierta = ventana.Estado == "abierta" &&
                                  now >= ventana.FechaInicio && now <= ventana.FechaFin;

                    if (abierta) return true;

                    // ¿excepción activa para el usuario que creó la evaluación?
                    if (eval.CreadoPorUsuarioId is null) return false;

                    var hayExcepcion = await _db.CalificacionesExcepciones
                        .AsNoTracking()
                        .AnyAsync(ex =>
                            ex.IdVentana == ventana.IdVentana &&
                            ex.UsuarioId == eval.CreadoPorUsuarioId &&
                            ex.FechaDesde <= now &&
                            (ex.FechaHasta == null || ex.FechaHasta >= now),
                            ct);

                    return hayExcepcion;
                })
                .WithMessage("La ventana de calificación está cerrada o no hay excepción activa.");
        }
    }

    public sealed class NotaUpdateValidator : AbstractValidator<NotaUpdateDto>
    {
        public NotaUpdateValidator()
        {
            // En UPDATE normalmente solo cambias el valor
            RuleFor(x => x.Valor)
                .InclusiveBetween(0m, 100m)
                .WithMessage("La nota debe estar entre 0 y 100.");
        }
    }
}
