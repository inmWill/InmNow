using InmNow.Domain.Base;

namespace InmNow.Domain.SurveyBuilder.Models
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
