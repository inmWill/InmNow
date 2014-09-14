namespace InmNow.Domain.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public string Question { get; set; }
        public int Type { get; set; }
        public string QuestionDescription { get; set; }
        public int MeetingId { get; set; }
    }
}
