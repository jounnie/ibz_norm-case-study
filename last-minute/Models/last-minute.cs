﻿using System;
using Microsoft.EntityFrameworkCore;

namespace last_minute.Models
{
    public class LastMinute
    {
        public int Id { get; set; }
        public string Flying_From { get; set; }
        public string Flying_To { get; set; }
        public DateTime Departure_Date { get; set; }
        public DateTime Arrival_Date { get; set; }
    }
}
