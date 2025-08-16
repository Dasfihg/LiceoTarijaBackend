using LiceoTarijaBackend.Application.DTOs.UsuariosRoles;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LiceoTarijaBackend.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosRolesController : ControllerBase
{
    private readonly LiceoTarijaDbContext _context;
    public UsuariosRolesController(LiceoTarijaDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UsuarioRol>>> GetAll()
        => await _context.UsuariosRoles.AsNoTracking().ToListAsync();

    [HttpGet("{idUsuario:int}/{rol}/{fechaDesde}")]
    public async Task<ActionResult<UsuarioRol>> Get(int idUsuario, string rol, DateOnly fechaDesde)
    {
        var item = await _context.UsuariosRoles.FindAsync(idUsuario, rol, fechaDesde);
        return item is null ? NotFound() : item;
    }

    [HttpPost]
    public async Task<ActionResult<UsuarioRol>> Post(UsuarioRol dto)
    {
        var exists = await _context.UsuariosRoles
            .AnyAsync(x => x.IdUsuario == dto.IdUsuario && x.Rol == dto.Rol && x.FechaDesde == dto.FechaDesde);
        if (exists) return Conflict("Ya existe un registro con esa clave compuesta.");

        _context.UsuariosRoles.Add(dto);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get),
            new { idUsuario = dto.IdUsuario, rol = dto.Rol, fechaDesde = dto.FechaDesde },
            dto);
    }

    [HttpPut("{idUsuario:int}/{rol}/{fechaDesde}")]
    public async Task<IActionResult> Put(int idUsuario, string rol, DateOnly fechaDesde, UsuarioRol dto)
    {
        if (idUsuario != dto.IdUsuario || rol != dto.Rol || fechaDesde != dto.FechaDesde)
            return BadRequest("La clave de la ruta no coincide con el cuerpo.");

        _context.Entry(dto).State = EntityState.Modified;

        try { await _context.SaveChangesAsync(); }
        catch (DbUpdateConcurrencyException)
        {
            var exists = await _context.UsuariosRoles
                .AnyAsync(x => x.IdUsuario == idUsuario && x.Rol == rol && x.FechaDesde == fechaDesde);
            if (!exists) return NotFound();
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{idUsuario:int}/{rol}/{fechaDesde}")]
    public async Task<IActionResult> Delete(int idUsuario, string rol, DateOnly fechaDesde)
    {
        var item = await _context.UsuariosRoles.FindAsync(idUsuario, rol, fechaDesde);
        if (item is null) return NotFound();

        _context.UsuariosRoles.Remove(item);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}


