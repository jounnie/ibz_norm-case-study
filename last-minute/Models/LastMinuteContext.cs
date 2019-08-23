using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using last_minute_shared;
using Microsoft.EntityFrameworkCore;

namespace last_minute.Models
{
    public class LastMinuteContext : DbContext
    {
        public LastMinuteContext(DbContextOptions<LastMinuteContext> options) : base(options) { }
        public DbSet<LastMinute> LastMinute { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
    }
}
