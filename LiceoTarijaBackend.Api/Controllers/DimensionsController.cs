using LiceoTarijaBackend.Application.DTOs.Dimensions;
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
    public class DimensionsController : ControllerBase
    {
        private readonly LiceoTarijaDbContext _context;

        public DimensionsController(LiceoTarijaDbContext context)
        {
            _context = context;
        }

        // GET: api/Dimensions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dimension>>> GetDimensiones()
        {
            return await _context.Dimensiones.ToListAsync();
        }

        // GET: api/Dimensions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dimension>> GetDimension(int id)
        {
            var dimension = await _context.Dimensiones.FindAsync(id);

            if (dimension == null)
            {
                return NotFound();
            }

            return dimension;
        }

        // PUT: api/Dimensions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimension(int id, Dimension dimension)
        {
            if (id != dimension.IdDimension)
            {
                return BadRequest();
            }

            _context.Entry(dimension).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimensionExists(id))
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

        // POST: api/Dimensions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dimension>> PostDimension(Dimension dimension)
        {
            _context.Dimensiones.Add(dimension);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimension", new { id = dimension.IdDimension }, dimension);
        }

        // DELETE: api/Dimensions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDimension(int id)
        {
            var dimension = await _context.Dimensiones.FindAsync(id);
            if (dimension == null)
            {
                return NotFound();
            }

            _context.Dimensiones.Remove(dimension);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DimensionExists(int id)
        {
            return _context.Dimensiones.Any(e => e.IdDimension == id);
        }
    }
}


