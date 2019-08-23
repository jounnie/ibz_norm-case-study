using System.Collections.Generic;
using System.Linq;
using hotel_service.Entities;
using last_minute_shared;
using Microsoft.AspNetCore.Mvc;

namespace hotel_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly HotelDbContext _context;

        public RoomsController(HotelDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Rooms>> Get()
        {
            return _context.Rooms.ToList();
        }
    }
}