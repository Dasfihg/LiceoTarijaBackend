using LiceoTarijaBackend.Application.DTOs.AsignacionHorarias;
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
    public class AsignacionesHorariasController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public AsignacionesHorariasController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/AsignacionesHorarias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AsignacionHoraria>>> GetAsignacionesHorarias()
        {
            return await _context.AsignacionesHorarias.ToListAsync();
        }

        // GET: api/AsignacionesHorarias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AsignacionHoraria>> GetAsignacionHoraria(int id)
        {
            var asignacionHoraria = await _context.AsignacionesHorarias.FindAsync(id);

            if (asignacionHoraria == null)
            {
                return NotFound();
            }

            return asignacionHoraria;
        }

        // PUT: api/AsignacionesHorarias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsignacionHoraria(int id, AsignacionHoraria asignacionHoraria)
        {
            if (id != asignacionHoraria.Id)
            {
                return BadRequest();
            }

            _context.Entry(asignacionHoraria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsignacionHorariaExists(id))
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

        // POST: api/AsignacionesHorarias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AsignacionHoraria>> PostAsignacionHoraria(AsignacionHoraria asignacionHoraria)
        {
            _context.AsignacionesHorarias.Add(asignacionHoraria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsignacionHoraria", new { id = asignacionHoraria.Id }, asignacionHoraria);
        }

        // DELETE: api/AsignacionesHorarias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsignacionHoraria(int id)
        {
            var asignacionHoraria = await _context.AsignacionesHorarias.FindAsync(id);
            if (asignacionHoraria == null)
            {
                return NotFound();
            }

            _context.AsignacionesHorarias.Remove(asignacionHoraria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsignacionHorariaExists(int id)
        {
            return _context.AsignacionesHorarias.Any(e => e.Id == id);
        }
    }
}


