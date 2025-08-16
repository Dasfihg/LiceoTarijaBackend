using LiceoTarijaBackend.Application.DTOs.UnidadEducativas;
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
    public class UnidadEducativasController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public UnidadEducativasController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/UnidadEducativas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadEducativa>>> GetUnidadesEducativas()
        {
            return await _context.UnidadesEducativas.ToListAsync();
        }

        // GET: api/UnidadEducativas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadEducativa>> GetUnidadEducativa(int id)
        {
            var unidadEducativa = await _context.UnidadesEducativas.FindAsync(id);

            if (unidadEducativa == null)
            {
                return NotFound();
            }

            return unidadEducativa;
        }

        // PUT: api/UnidadEducativas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidadEducativa(int id, UnidadEducativa unidadEducativa)
        {
            if (id != unidadEducativa.IdUnidad)
            {
                return BadRequest();
            }

            _context.Entry(unidadEducativa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadEducativaExists(id))
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

        // POST: api/UnidadEducativas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UnidadEducativa>> PostUnidadEducativa(UnidadEducativa unidadEducativa)
        {
            _context.UnidadesEducativas.Add(unidadEducativa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnidadEducativa", new { id = unidadEducativa.IdUnidad }, unidadEducativa);
        }

        // DELETE: api/UnidadEducativas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidadEducativa(int id)
        {
            var unidadEducativa = await _context.UnidadesEducativas.FindAsync(id);
            if (unidadEducativa == null)
            {
                return NotFound();
            }

            _context.UnidadesEducativas.Remove(unidadEducativa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnidadEducativaExists(int id)
        {
            return _context.UnidadesEducativas.Any(e => e.IdUnidad == id);
        }
    }
}


