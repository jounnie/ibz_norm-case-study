using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using last_minute.Models;

namespace last_minute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LastMinutesController : ControllerBase
    {
        private readonly LastMinuteContext _context;

        public LastMinutesController(LastMinuteContext context)
        {
            _context = context;
        }

        // GET: api/LastMinutes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LastMinute>>> GetLastMinute()
        {
            return await _context.LastMinute.ToListAsync();
        }

        // GET: api/LastMinutes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LastMinute>> GetLastMinute(long id)
        {
            var lastMinute = await _context.LastMinute.FindAsync(id);

            if (lastMinute == null)
            {
                return NotFound();
            }

            return lastMinute;
        }

        // PUT: api/LastMinutes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLastMinute(long id, LastMinute lastMinute)
        {
            if (id != lastMinute.Id)
            {
                return BadRequest();
            }

            _context.Entry(lastMinute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LastMinuteExists(id))
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

        // POST: api/LastMinutes
        [HttpPost]
        public async Task<ActionResult<LastMinute>> PostLastMinute(LastMinute lastMinute)
        {
            _context.LastMinute.Add(lastMinute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLastMinute", new { id = lastMinute.Id }, lastMinute);
        }

        // DELETE: api/LastMinutes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LastMinute>> DeleteLastMinute(long id)
        {
            var lastMinute = await _context.LastMinute.FindAsync(id);
            if (lastMinute == null)
            {
                return NotFound();
            }

            _context.LastMinute.Remove(lastMinute);
            await _context.SaveChangesAsync();

            return lastMinute;
        }

        private bool LastMinuteExists(long id)
        {
            return _context.LastMinute.Any(e => e.Id == id);
        }
    }
}
