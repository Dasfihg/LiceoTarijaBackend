using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LiceoTarijaBackend.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApoderadosEstudiantesController : ControllerBase
{
    private readonly LiceoTarijaDbContext _context;
    public ApoderadosEstudiantesController(LiceoTarijaDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ApoderadoEstudiante>>> GetAll()
        => await _context.ApoderadosEstudiantes.AsNoTracking().ToListAsync();

    [HttpGet("{idApoderado:int}/{idEstudiante:int}/{fechaDesde}")]
    public async Task<ActionResult<ApoderadoEstudiante>> Get(int idApoderado, int idEstudiante, DateOnly fechaDesde)
    {
        var item = await _context.ApoderadosEstudiantes.FindAsync(idApoderado, idEstudiante, fechaDesde);
        return item is null ? NotFound() : item;
    }

    [HttpPost]
    public async Task<ActionResult<ApoderadoEstudiante>> Post([FromBody] ApoderadoEstudiante dto)
    {
        var exists = await _context.ApoderadosEstudiantes.AsNoTracking()
            .AnyAsync(x => x.IdApoderado == dto.IdApoderado &&
                           x.IdEstudiante == dto.IdEstudiante &&
                           x.FechaDesde == dto.FechaDesde);
        if (exists) return Conflict("Ya existe un registro con esa clave compuesta.");

        _context.ApoderadosEstudiantes.Add(dto);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get),
            new { idApoderado = dto.IdApoderado, idEstudiante = dto.IdEstudiante, fechaDesde = dto.FechaDesde },
            dto);
    }

    [HttpPut("{idApoderado:int}/{idEstudiante:int}/{fechaDesde}")]
    public async Task<IActionResult> Put(int idApoderado, int idEstudiante, DateOnly fechaDesde, [FromBody] ApoderadoEstudiante dto)
    {
        if (idApoderado != dto.IdApoderado || idEstudiante != dto.IdEstudiante || fechaDesde != dto.FechaDesde)
            return BadRequest("La clave de la ruta no coincide con el cuerpo.");

        _context.Entry(dto).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            var exists = await _context.ApoderadosEstudiantes.AsNoTracking()
                .AnyAsync(x => x.IdApoderado == idApoderado && x.IdEstudiante == idEstudiante && x.FechaDesde == fechaDesde);
            if (!exists) return NotFound();
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{idApoderado:int}/{idEstudiante:int}/{fechaDesde}")]
    public async Task<IActionResult> Delete(int idApoderado, int idEstudiante, DateOnly fechaDesde)
    {
        var item = await _context.ApoderadosEstudiantes.FindAsync(idApoderado, idEstudiante, fechaDesde);
        if (item is null) return NotFound();

        _context.ApoderadosEstudiantes.Remove(item);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
