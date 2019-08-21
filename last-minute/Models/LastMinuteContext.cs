using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace last_minute.Models
{
    public class LastMinuteContext : DbContext
    {
        public LastMinuteContext(DbContextOptions<LastMinuteContext> options) : base(options) { }
        public DbSet<LastMinute> LastMinute { get; set; }
    }
}
