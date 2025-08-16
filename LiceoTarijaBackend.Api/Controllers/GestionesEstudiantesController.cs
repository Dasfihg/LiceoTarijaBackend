using LiceoTarijaBackend.Application.DTOs.GestionEstudiantes;
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
    public class GestionesEstudiantesController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public GestionesEstudiantesController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/GestionesEstudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GestionEstudiante>>> GetGestionesEstudiantes()
        {
            return await _context.GestionesEstudiantes.ToListAsync();
        }

        // GET: api/GestionesEstudiantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GestionEstudiante>> GetGestionEstudiante(int id)
        {
            var gestionEstudiante = await _context.GestionesEstudiantes.FindAsync(id);

            if (gestionEstudiante == null)
            {
                return NotFound();
            }

            return gestionEstudiante;
        }

        // PUT: api/GestionesEstudiantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestionEstudiante(int id, GestionEstudiante gestionEstudiante)
        {
            if (id != gestionEstudiante.IdGestionEstudiante)
            {
                return BadRequest();
            }

            _context.Entry(gestionEstudiante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GestionEstudianteExists(id))
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

        // POST: api/GestionesEstudiantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GestionEstudiante>> PostGestionEstudiante(GestionEstudiante gestionEstudiante)
        {
            _context.GestionesEstudiantes.Add(gestionEstudiante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGestionEstudiante", new { id = gestionEstudiante.IdGestionEstudiante }, gestionEstudiante);
        }

        // DELETE: api/GestionesEstudiantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestionEstudiante(int id)
        {
            var gestionEstudiante = await _context.GestionesEstudiantes.FindAsync(id);
            if (gestionEstudiante == null)
            {
                return NotFound();
            }

            _context.GestionesEstudiantes.Remove(gestionEstudiante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GestionEstudianteExists(int id)
        {
            return _context.GestionesEstudiantes.Any(e => e.IdGestionEstudiante == id);
        }
    }
}


