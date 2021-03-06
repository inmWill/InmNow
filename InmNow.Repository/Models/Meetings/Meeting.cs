using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class Meeting : BaseEntity
    {
        public int MeetingId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string OfficeEmail { get; set; }
        public string SupportEmail { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string UserId { get; set; }
    }
}
