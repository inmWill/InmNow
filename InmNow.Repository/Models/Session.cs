using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class Session
    {
        public Session()
        {
            this.Abstracts = new List<Abstract>();
            this.Abstracts1 = new List<Abstract>();
        }

        public int SessionId { get; set; }
        public int Phase { get; set; }
        public string Code { get; set; }
        public string SessionTitle { get; set; }
        public string Contact { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int TrackId { get; set; }
        public Nullable<int> Abstract_AbstractId { get; set; }
        public virtual ICollection<Abstract> Abstracts { get; set; }
        public virtual ICollection<Abstract> Abstracts1 { get; set; }
        public virtual Abstract Abstract { get; set; }
        public virtual Track Track { get; set; }
    }
}
