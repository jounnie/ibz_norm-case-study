using System.Collections.Generic;
using System.Linq;
using airline_service.Entities;
using last_minute_shared;
using Microsoft.AspNetCore.Mvc;

namespace airline_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly AirlineDbContext _context;

        public FlightsController(AirlineDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Flights>> Get()
        {
            return _context.Flights.ToList();
        }
    }
}