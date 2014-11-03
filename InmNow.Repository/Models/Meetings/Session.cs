using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class Session : BaseEntity
    {
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
    }
}
