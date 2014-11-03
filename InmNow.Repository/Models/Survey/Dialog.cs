using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models.Survey
{
    public class Dialog : BaseEntity
    {
        public int DialogId { get; set; }
        public int PromptingQuestionId { get; set; }
        public int RespondingQuestionId { get; set; }
        public bool? TriggerOnBool { get; set; }
        public string TriggerOnPhrase { get; set; }
        public decimal? TriggerOnDecimalLow { get; set; }
        public decimal? TriggerOnDecimalHigh { get; set; }
    }
}
