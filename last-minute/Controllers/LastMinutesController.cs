using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using last_minute.Models;
using last_minute_shared;
using Newtonsoft.Json;

namespace last_minute.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class LastMinutesController : ControllerBase
    {
        private readonly LastMinuteContext _context;
        private readonly IHttpClientFactory _clientFactory;

        public LastMinutesController(LastMinuteContext context, IHttpClientFactory clientFactory)
        {
            _context = context;
            _clientFactory = clientFactory;
        }

        // GET: api/LastMinutes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LastMinute>>> GetLastMinute()
        {
            var offers = await _context.LastMinute.ToListAsync();

            foreach (var offer in offers)
            {
                var flight = await _context.Flights.FindAsync(offer.Flight_Id);
                var room = await _context.Rooms.FindAsync(offer.Room_id);
                offer.Flights = flight;
                offer.Rooms = room;
            }
            
            return offers;
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
        
        [HttpGet("reload")]
        public async Task<IActionResult> ReloadData()
        {
            var httpClient = _clientFactory.CreateClient();
            var response = await httpClient.GetStringAsync("http://localhost:5000/api/flights");
            var responseRooms = await httpClient.GetStringAsync("http://localhost:5010/api/rooms");

            List<Flights> flights = (List<Flights>) JsonConvert.DeserializeObject(response, typeof(List<Flights>));
            List<Rooms> rooms = (List<Rooms>) JsonConvert.DeserializeObject(responseRooms, typeof(List<Rooms>));

            foreach (var flight in flights)
            {
                _context.Flights.Add(flight);                
            }
            foreach (var room in rooms)
            {
                _context.Rooms.Add(room);
            }
            
            

            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        private bool LastMinuteExists(long id)
        {
            return _context.LastMinute.Any(e => e.Id == id);
        }
    }
}
