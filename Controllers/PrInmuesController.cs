using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRealState.Models;

namespace ApiRealState.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrInmuesController : ControllerBase
    {
        private readonly PaverloProjectContext _context;

        public PrInmuesController(PaverloProjectContext context)
        {
            _context = context;
        }

        // GET: api/PrInmues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrInmue>>> GetPrInmues()
        {
          if (_context.PrInmues == null)
          {
              return NotFound();
          }
            return await _context.PrInmues.ToListAsync();
        }

        // GET: api/PrInmues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrInmue>> GetPrInmue(int id)
        {
          if (_context.PrInmues == null)
          {
              return NotFound();
          }
            var prInmue = await _context.PrInmues.FindAsync(id);

            if (prInmue == null)
            {
                return NotFound();
            }

            return prInmue;
        }

        // PUT: api/PrInmues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrInmue(int id, PrInmue prInmue)
        {
            if (id != prInmue.IdeInmu)
            {
                return BadRequest();
            }

            _context.Entry(prInmue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrInmueExists(id))
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

        // POST: api/PrInmues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrInmue>> PostPrInmue(PrInmue prInmue)
        {
          if (_context.PrInmues == null)
          {
              return Problem("Entity set 'PaverloProjectContext.PrInmues'  is null.");
          }
            _context.PrInmues.Add(prInmue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrInmue", new { id = prInmue.IdeInmu }, prInmue);
        }

        // DELETE: api/PrInmues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrInmue(int id)
        {
            if (_context.PrInmues == null)
            {
                return NotFound();
            }
            var prInmue = await _context.PrInmues.FindAsync(id);
            if (prInmue == null)
            {
                return NotFound();
            }

            _context.PrInmues.Remove(prInmue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrInmueExists(int id)
        {
            return (_context.PrInmues?.Any(e => e.IdeInmu == id)).GetValueOrDefault();
        }
    }
}
