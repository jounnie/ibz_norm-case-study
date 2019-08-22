using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace last_minute.Models
{
    public class airlineModel
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Flying_From { get; set; }
        public string Flying_To { get; set; }
        public DateTime Departure_Date { get; set; }
        public string Company { get; set; }
    }
}
