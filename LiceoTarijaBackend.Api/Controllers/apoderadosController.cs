using LiceoTarijaBackend.Application.DTOs.Apoderados;
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
    public class ApoderadosController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public ApoderadosController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/Apoderados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apoderado>>> GetApoderados()
        {
            return await _context.Apoderados.ToListAsync();
        }

        // GET: api/Apoderados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Apoderado>> GetApoderado(int id)
        {
            var apoderado = await _context.Apoderados.FindAsync(id);

            if (apoderado == null)
            {
                return NotFound();
            }

            return apoderado;
        }

        // PUT: api/Apoderados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApoderado(int id, Apoderado apoderado)
        {
            if (id != apoderado.IdApoderado)
            {
                return BadRequest();
            }

            _context.Entry(apoderado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApoderadoExists(id))
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

        // POST: api/Apoderados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Apoderado>> PostApoderado(Apoderado apoderado)
        {
            _context.Apoderados.Add(apoderado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApoderado", new { id = apoderado.IdApoderado }, apoderado);
        }

        // DELETE: api/Apoderados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApoderado(int id)
        {
            var apoderado = await _context.Apoderados.FindAsync(id);
            if (apoderado == null)
            {
                return NotFound();
            }

            _context.Apoderados.Remove(apoderado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApoderadoExists(int id)
        {
            return _context.Apoderados.Any(e => e.IdApoderado == id);
        }
    }
}


