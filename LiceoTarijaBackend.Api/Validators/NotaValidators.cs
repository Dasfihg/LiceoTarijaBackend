using FluentValidation;
using Microsoft.EntityFrameworkCore;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Application.DTOs.Notas;

namespace LiceoTarijaBackend.Api.Validators
{
    public sealed class NotaCreateValidator : AbstractValidator<NotaCreateDto>
    {
        public NotaCreateValidator(LiceoTarijaDbContext db)
        {
            // 1) Rango permitido
            RuleFor(x => x.Valor)
                .InclusiveBetween(0m, 100m)
                .WithMessage("La nota debe estar entre 0 y 100.");

            // 2) FKs vÃ¡lidos
            RuleFor(x => x.IdGestionEstudiante)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await db.GestionesEstudiantes.AsNoTracking().AnyAsync(g => g.IdGestionEstudiante == id, ct))
                .WithMessage("GestiÃ³n-Estudiante inexistente.");

            RuleFor(x => x.IdEvaluacion)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await db.Evaluaciones.AsNoTracking().AnyAsync(e => e.IdEvaluacion == id, ct))
                .WithMessage("EvaluaciÃ³n inexistente.");

            // 3) Evitar duplicados (misma evaluaciÃ³n para el mismo estudiante)
            RuleFor(x => x)
                .MustAsync(async (dto, ct) =>
                    !await db.Notas.AsNoTracking().AnyAsync(n =>
                        n.IdGestionEstudiante == dto.IdGestionEstudiante &&
                        n.IdEvaluacion == dto.IdEvaluacion &&
                        n.DeletedAt == null, ct))
                .WithMessage("Ya existe una nota para ese estudiante en esa evaluaciÃ³n.");

            // 4) Ventana de calificaciÃ³n abierta (o excepciÃ³n activa)
            RuleFor(x => x.IdEvaluacion)
                .MustAsync(async (idEval, ct) =>
                {
                    var eval = await db.Evaluaciones
                        .AsNoTracking()
                        .FirstOrDefaultAsync(e => e.IdEvaluacion == idEval, ct);
                    if (eval is null) return false;

                    // gestiÃ³n de la evaluaciÃ³n
                    var gestionId = await db.CursosGestion
                        .Where(cg => cg.IdCursoGestion == eval.IdCursoGestion)
                        .Select(cg => cg.IdGestion)
                        .FirstOrDefaultAsync(ct);

                    var ventana = await db.CalificacionesVentanas
                        .AsNoTracking()
                        .FirstOrDefaultAsync(v => v.IdGestion == gestionId && v.IdPeriodo == eval.IdPeriodo, ct);

                    if (ventana is null) return false;

                    var now = DateTime.UtcNow;
                    var abierta = ventana.Estado == "abierta" &&
                                  now >= ventana.FechaInicio && now <= ventana.FechaFin;

                    if (abierta) return true;

                    // Â¿excepciÃ³n activa para el usuario que creÃ³ la evaluaciÃ³n?
                    if (eval.CreadoPorUsuarioId is null) return false;

                    var hayExcepcion = await db.CalificacionesExcepciones
                        .AsNoTracking()
                        .AnyAsync(ex =>
                            ex.IdVentana == ventana.IdVentana &&
                            ex.UsuarioId == eval.CreadoPorUsuarioId &&
                            ex.FechaDesde <= now &&
                            (ex.FechaHasta == null || ex.FechaHasta >= now),
                            ct);

                    return hayExcepcion;
                })
                .WithMessage("La ventana de calificaciÃ³n estÃ¡ cerrada o no hay excepciÃ³n activa.");
        }
    }

    public sealed class NotaUpdateValidator : AbstractValidator<NotaUpdateDto>
    {
        public NotaUpdateValidator(LiceoTarijaDbContext db)
        {
            // En UPDATE normalmente solo cambias el valor
            RuleFor(x => x.Valor)
                .InclusiveBetween(0m, 100m)
                .WithMessage("La nota debe estar entre 0 y 100.");

            // Si tu UpdateDto incluyera FKs, puedes reactivar estas reglas:
            /*
            RuleFor(x => x.IdGestionEstudiante)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await db.GestionesEstudiantes.AsNoTracking().AnyAsync(g => g.IdGestionEstudiante == id, ct))
                .WithMessage("GestiÃ³n-Estudiante inexistente.");

            RuleFor(x => x.IdEvaluacion)
                .GreaterThan(0)
                .MustAsync(async (id, ct) =>
                    await db.Evaluaciones.AsNoTracking().AnyAsync(e => e.IdEvaluacion == id, ct))
                .WithMessage("EvaluaciÃ³n inexistente.");
            */
        }
    }
}

