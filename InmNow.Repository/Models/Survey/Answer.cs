using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models.Survey
{
    public class Answer : BaseEntity
    {
        public int AnswerId { get; set; }
        public string TextAnswer { get; set; }
        public bool? BooleanAnswer { get; set; }
        public decimal DecimalAnswer { get; set; }
 
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public int UserId { get; set; }
        public virtual InmUser User { get; set; }
    }
}
