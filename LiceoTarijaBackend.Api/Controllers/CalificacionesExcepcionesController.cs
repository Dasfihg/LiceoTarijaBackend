using LiceoTarijaBackend.Application.DTOs.CalificacionesExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Infrastructure.Data;

namespace LiceoTarijaBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionesExcepcionesController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public CalificacionesExcepcionesController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/CalificacionesExcepciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalificacionesExcepcion>>> GetCalificacionesExcepciones()
        {
            return await _context.CalificacionesExcepciones.ToListAsync();
        }

        // GET: api/CalificacionesExcepciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalificacionesExcepcion>> GetCalificacionesExcepcion(int id)
        {
            var calificacionesExcepcion = await _context.CalificacionesExcepciones.FindAsync(id);

            if (calificacionesExcepcion == null)
            {
                return NotFound();
            }

            return calificacionesExcepcion;
        }

        // PUT: api/CalificacionesExcepciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalificacionesExcepcion(int id, CalificacionesExcepcion calificacionesExcepcion)
        {
            if (id != calificacionesExcepcion.IdExcepcion)
            {
                return BadRequest();
            }

            _context.Entry(calificacionesExcepcion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalificacionesExcepcionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CalificacionesExcepciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CalificacionesExcepcion>> PostCalificacionesExcepcion(CalificacionesExcepcion calificacionesExcepcion)
        {
            _context.CalificacionesExcepciones.Add(calificacionesExcepcion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalificacionesExcepcion", new { id = calificacionesExcepcion.IdExcepcion }, calificacionesExcepcion);
        }

        // DELETE: api/CalificacionesExcepciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalificacionesExcepcion(int id)
        {
            var calificacionesExcepcion = await _context.CalificacionesExcepciones.FindAsync(id);
            if (calificacionesExcepcion == null)
            {
                return NotFound();
            }

            _context.CalificacionesExcepciones.Remove(calificacionesExcepcion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalificacionesExcepcionExists(int id)
        {
            return _context.CalificacionesExcepciones.Any(e => e.IdExcepcion == id);
        }
    }
}


