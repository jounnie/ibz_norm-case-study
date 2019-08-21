using System;
using Microsoft.EntityFrameworkCore;

namespace airline_service.Entities
{
    public class AirlineDbContext : DbContext
    {
        public AirlineDbContext(DbContextOptions<AirlineDbContext> options) : base(options)
        {
        }

        public DbSet<Flights> Flights { get; set; }
    }

    public class Flights
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Flying_From { get; set; }
        public string Flying_To { get; set; }
        public DateTime Departure_Date { get; set; }
        public string Company { get; set; }
    }
}