using LiceoTarijaBackend.Application.DTOs.BloqueHorarios;
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
    public class BloquesHorariosController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public BloquesHorariosController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/BloquesHorarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloqueHorario>>> GetBloquesHorarios()
        {
            return await _context.BloquesHorarios.ToListAsync();
        }

        // GET: api/BloquesHorarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BloqueHorario>> GetBloqueHorario(int id)
        {
            var bloqueHorario = await _context.BloquesHorarios.FindAsync(id);

            if (bloqueHorario == null)
            {
                return NotFound();
            }

            return bloqueHorario;
        }

        // PUT: api/BloquesHorarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloqueHorario(int id, BloqueHorario bloqueHorario)
        {
            if (id != bloqueHorario.IdBloque)
            {
                return BadRequest();
            }

            _context.Entry(bloqueHorario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloqueHorarioExists(id))
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

        // POST: api/BloquesHorarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BloqueHorario>> PostBloqueHorario(BloqueHorario bloqueHorario)
        {
            _context.BloquesHorarios.Add(bloqueHorario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloqueHorario", new { id = bloqueHorario.IdBloque }, bloqueHorario);
        }

        // DELETE: api/BloquesHorarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloqueHorario(int id)
        {
            var bloqueHorario = await _context.BloquesHorarios.FindAsync(id);
            if (bloqueHorario == null)
            {
                return NotFound();
            }

            _context.BloquesHorarios.Remove(bloqueHorario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BloqueHorarioExists(int id)
        {
            return _context.BloquesHorarios.Any(e => e.IdBloque == id);
        }
    }
}


