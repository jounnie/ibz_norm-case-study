using System;
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

    public class Rooms
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
    }
}