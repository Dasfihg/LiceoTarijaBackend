using LiceoTarijaBackend.Application.DTOs.CursosGestion;
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
    public class CursosGestionController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public CursosGestionController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/CursosGestion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoGestion>>> GetCursosGestion()
        {
            return await _context.CursosGestion.ToListAsync();
        }

        // GET: api/CursosGestion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoGestion>> GetCursoGestion(int id)
        {
            var cursoGestion = await _context.CursosGestion.FindAsync(id);

            if (cursoGestion == null)
            {
                return NotFound();
            }

            return cursoGestion;
        }

        // PUT: api/CursosGestion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursoGestion(int id, CursoGestion cursoGestion)
        {
            if (id != cursoGestion.IdCursoGestion)
            {
                return BadRequest();
            }

            _context.Entry(cursoGestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoGestionExists(id))
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

        // POST: api/CursosGestion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CursoGestion>> PostCursoGestion(CursoGestion cursoGestion)
        {
            _context.CursosGestion.Add(cursoGestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursoGestion", new { id = cursoGestion.IdCursoGestion }, cursoGestion);
        }

        // DELETE: api/CursosGestion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursoGestion(int id)
        {
            var cursoGestion = await _context.CursosGestion.FindAsync(id);
            if (cursoGestion == null)
            {
                return NotFound();
            }

            _context.CursosGestion.Remove(cursoGestion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoGestionExists(int id)
        {
            return _context.CursosGestion.Any(e => e.IdCursoGestion == id);
        }
    }
}


