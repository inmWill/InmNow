using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int MeetingId { get; set; }
    }
}
