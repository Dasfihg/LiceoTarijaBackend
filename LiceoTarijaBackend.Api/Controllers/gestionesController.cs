using LiceoTarijaBackend.Application.DTOs.Gestiones;
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
    public class GestionesController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public GestionesController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/Gestiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gestion>>> GetGestiones()
        {
            return await _context.Gestiones.ToListAsync();
        }

        // GET: api/Gestiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gestion>> GetGestion(int id)
        {
            var gestion = await _context.Gestiones.FindAsync(id);

            if (gestion == null)
            {
                return NotFound();
            }

            return gestion;
        }

        // PUT: api/Gestiones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestion(int id, Gestion gestion)
        {
            if (id != gestion.IdGestion)
            {
                return BadRequest();
            }

            _context.Entry(gestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GestionExists(id))
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

        // POST: api/Gestiones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gestion>> PostGestion(Gestion gestion)
        {
            _context.Gestiones.Add(gestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGestion", new { id = gestion.IdGestion }, gestion);
        }

        // DELETE: api/Gestiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestion(int id)
        {
            var gestion = await _context.Gestiones.FindAsync(id);
            if (gestion == null)
            {
                return NotFound();
            }

            _context.Gestiones.Remove(gestion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GestionExists(int id)
        {
            return _context.Gestiones.Any(e => e.IdGestion == id);
        }
    }
}


