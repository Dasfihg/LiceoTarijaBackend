using LiceoTarijaBackend.Application.DTOs.GestionProfesores;
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
    public class GestionesProfesoresController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public GestionesProfesoresController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/GestionesProfesores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GestionProfesor>>> GetGestionesProfesores()
        {
            return await _context.GestionesProfesores.ToListAsync();
        }

        // GET: api/GestionesProfesores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GestionProfesor>> GetGestionProfesor(int id)
        {
            var gestionProfesor = await _context.GestionesProfesores.FindAsync(id);

            if (gestionProfesor == null)
            {
                return NotFound();
            }

            return gestionProfesor;
        }

        // PUT: api/GestionesProfesores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestionProfesor(int id, GestionProfesor gestionProfesor)
        {
            if (id != gestionProfesor.IdGestionProfesor)
            {
                return BadRequest();
            }

            _context.Entry(gestionProfesor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GestionProfesorExists(id))
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

        // POST: api/GestionesProfesores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GestionProfesor>> PostGestionProfesor(GestionProfesor gestionProfesor)
        {
            _context.GestionesProfesores.Add(gestionProfesor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGestionProfesor", new { id = gestionProfesor.IdGestionProfesor }, gestionProfesor);
        }

        // DELETE: api/GestionesProfesores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestionProfesor(int id)
        {
            var gestionProfesor = await _context.GestionesProfesores.FindAsync(id);
            if (gestionProfesor == null)
            {
                return NotFound();
            }

            _context.GestionesProfesores.Remove(gestionProfesor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GestionProfesorExists(int id)
        {
            return _context.GestionesProfesores.Any(e => e.IdGestionProfesor == id);
        }
    }
}


