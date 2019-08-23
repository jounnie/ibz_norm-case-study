using System;
using last_minute_shared;
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
}