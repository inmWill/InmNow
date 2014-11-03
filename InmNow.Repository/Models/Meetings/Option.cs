using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class Option : BaseEntity
    {
        public int OptionId { get; set; }
        public string Question { get; set; }
        public int Type { get; set; }
        public string QuestionDescription { get; set; }
        public int MeetingId { get; set; }
    }
}
