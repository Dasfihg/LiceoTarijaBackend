using LiceoTarijaBackend.Application.DTOs.CursoAreaProfesores;
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
    public class CursosAreasProfesoresController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public CursosAreasProfesoresController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/CursosAreasProfesores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoAreaProfesor>>> GetCursosAreasProfesores()
        {
            return await _context.CursosAreasProfesores.ToListAsync();
        }

        // GET: api/CursosAreasProfesores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoAreaProfesor>> GetCursoAreaProfesor(int id)
        {
            var cursoAreaProfesor = await _context.CursosAreasProfesores.FindAsync(id);

            if (cursoAreaProfesor == null)
            {
                return NotFound();
            }

            return cursoAreaProfesor;
        }

        // PUT: api/CursosAreasProfesores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursoAreaProfesor(int id, CursoAreaProfesor cursoAreaProfesor)
        {
            if (id != cursoAreaProfesor.Id)
            {
                return BadRequest();
            }

            _context.Entry(cursoAreaProfesor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoAreaProfesorExists(id))
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

        // POST: api/CursosAreasProfesores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CursoAreaProfesor>> PostCursoAreaProfesor(CursoAreaProfesor cursoAreaProfesor)
        {
            _context.CursosAreasProfesores.Add(cursoAreaProfesor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursoAreaProfesor", new { id = cursoAreaProfesor.Id }, cursoAreaProfesor);
        }

        // DELETE: api/CursosAreasProfesores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursoAreaProfesor(int id)
        {
            var cursoAreaProfesor = await _context.CursosAreasProfesores.FindAsync(id);
            if (cursoAreaProfesor == null)
            {
                return NotFound();
            }

            _context.CursosAreasProfesores.Remove(cursoAreaProfesor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoAreaProfesorExists(int id)
        {
            return _context.CursosAreasProfesores.Any(e => e.Id == id);
        }
    }
}


