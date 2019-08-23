using System;

namespace last_minute_shared
{
    public class Flights
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Uuid { get; set; }
        public string Flying_From { get; set; }
        public string Flying_To { get; set; }
        public DateTime Departure_Date_Time { get; set; }
        public string Company { get; set; }
    }
}