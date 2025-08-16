using LiceoTarijaBackend.Application.DTOs.CalificacionesVentanas;
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
    public class CalificacionesVentanasController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public CalificacionesVentanasController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/CalificacionesVentanas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalificacionesVentana>>> GetCalificacionesVentanas()
        {
            return await _context.CalificacionesVentanas.ToListAsync();
        }

        // GET: api/CalificacionesVentanas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalificacionesVentana>> GetCalificacionesVentana(int id)
        {
            var calificacionesVentana = await _context.CalificacionesVentanas.FindAsync(id);

            if (calificacionesVentana == null)
            {
                return NotFound();
            }

            return calificacionesVentana;
        }

        // PUT: api/CalificacionesVentanas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalificacionesVentana(int id, CalificacionesVentana calificacionesVentana)
        {
            if (id != calificacionesVentana.IdVentana)
            {
                return BadRequest();
            }

            _context.Entry(calificacionesVentana).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalificacionesVentanaExists(id))
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

        // POST: api/CalificacionesVentanas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CalificacionesVentana>> PostCalificacionesVentana(CalificacionesVentana calificacionesVentana)
        {
            _context.CalificacionesVentanas.Add(calificacionesVentana);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalificacionesVentana", new { id = calificacionesVentana.IdVentana }, calificacionesVentana);
        }

        // DELETE: api/CalificacionesVentanas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalificacionesVentana(int id)
        {
            var calificacionesVentana = await _context.CalificacionesVentanas.FindAsync(id);
            if (calificacionesVentana == null)
            {
                return NotFound();
            }

            _context.CalificacionesVentanas.Remove(calificacionesVentana);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalificacionesVentanaExists(int id)
        {
            return _context.CalificacionesVentanas.Any(e => e.IdVentana == id);
        }
    }
}


