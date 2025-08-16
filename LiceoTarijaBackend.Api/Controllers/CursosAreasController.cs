using LiceoTarijaBackend.Application.DTOs.CursoAreas;
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
    public class CursosAreasController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public CursosAreasController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/CursosAreas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoArea>>> GetCursosAreas()
        {
            return await _context.CursosAreas.ToListAsync();
        }

        // GET: api/CursosAreas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoArea>> GetCursoArea(int id)
        {
            var cursoArea = await _context.CursosAreas.FindAsync(id);

            if (cursoArea == null)
            {
                return NotFound();
            }

            return cursoArea;
        }

        // PUT: api/CursosAreas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursoArea(int id, CursoArea cursoArea)
        {
            if (id != cursoArea.IdCursoArea)
            {
                return BadRequest();
            }

            _context.Entry(cursoArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoAreaExists(id))
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

        // POST: api/CursosAreas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CursoArea>> PostCursoArea(CursoArea cursoArea)
        {
            _context.CursosAreas.Add(cursoArea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursoArea", new { id = cursoArea.IdCursoArea }, cursoArea);
        }

        // DELETE: api/CursosAreas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursoArea(int id)
        {
            var cursoArea = await _context.CursosAreas.FindAsync(id);
            if (cursoArea == null)
            {
                return NotFound();
            }

            _context.CursosAreas.Remove(cursoArea);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoAreaExists(int id)
        {
            return _context.CursosAreas.Any(e => e.IdCursoArea == id);
        }
    }
}


