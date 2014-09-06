using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class Track
    {
        public Track()
        {
            this.Sessions = new List<Session>();
        }

        public int TrackId { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int MeetingId { get; set; }
        public virtual Meeting Meeting { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
