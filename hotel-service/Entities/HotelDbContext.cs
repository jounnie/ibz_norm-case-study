using System;
using last_minute_shared;
using Microsoft.EntityFrameworkCore;

namespace hotel_service.Entities
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Rooms> Rooms { get; set; }
    }
}