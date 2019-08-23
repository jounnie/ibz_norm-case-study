using System;

namespace last_minute.Models
{
    public class LastMinute
    {
        public int Id { get; set; }
        public int Flight_Id { get; set; }
        public int Room_id { get; set; }
        public DateTime Create_Date { get; set; }
    }
}
