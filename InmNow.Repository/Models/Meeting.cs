using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class Meeting
    {
        public Meeting()
        {
            this.Options = new List<Option>();
            this.Tracks = new List<Track>();
        }

        public int MeetingId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string OfficeEmail { get; set; }
        public string SupportEmail { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
