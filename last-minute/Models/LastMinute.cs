using System;
using last_minute_shared;

namespace last_minute.Models
{
    public class LastMinute
    {
        public int Id { get; set; }
        public int Flight_Id { get; set; }
        public int Room_id { get; set; }
        public DateTime Create_Date { get; set; }

        public Flights Flights { get; set; }
        public Rooms Rooms { get; set; }
    }
}
