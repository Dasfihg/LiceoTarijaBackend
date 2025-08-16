using LiceoTarijaBackend.Application.DTOs.Observaciones;
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
    public class ObservacionsController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public ObservacionsController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/Observacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Observacion>>> GetObservaciones()
        {
            return await _context.Observaciones.ToListAsync();
        }

        // GET: api/Observacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Observacion>> GetObservacion(int id)
        {
            var observacion = await _context.Observaciones.FindAsync(id);

            if (observacion == null)
            {
                return NotFound();
            }

            return observacion;
        }

        // PUT: api/Observacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObservacion(int id, Observacion observacion)
        {
            if (id != observacion.IdObservacion)
            {
                return BadRequest();
            }

            _context.Entry(observacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObservacionExists(id))
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

        // POST: api/Observacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Observacion>> PostObservacion(Observacion observacion)
        {
            _context.Observaciones.Add(observacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObservacion", new { id = observacion.IdObservacion }, observacion);
        }

        // DELETE: api/Observacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObservacion(int id)
        {
            var observacion = await _context.Observaciones.FindAsync(id);
            if (observacion == null)
            {
                return NotFound();
            }

            _context.Observaciones.Remove(observacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObservacionExists(int id)
        {
            return _context.Observaciones.Any(e => e.IdObservacion == id);
        }
    }
}


