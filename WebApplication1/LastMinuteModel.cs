using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class LastMinuteModel
    {
        public int Id { get; set; }
        public string Flying_From { get; set; }
        public string Flying_To { get; set; }
        public DateTime Departure_Date { get; set; }
        public DateTime Arrival_Date { get; set; }
    }
}
