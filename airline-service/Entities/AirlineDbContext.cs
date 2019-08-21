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
        public string Name { get; set; }
    }
}