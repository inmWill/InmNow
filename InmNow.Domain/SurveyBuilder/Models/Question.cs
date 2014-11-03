using System.Collections.Generic;
using InmNow.Enums;
using InmNow.Domain.Base;

namespace InmNow.Domain.SurveyBuilder.Models
{
    public class Question : BaseEntity
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string QuestionText { get; set; }
        public string QuestionSubText { get; set; }
        
        public QuestionType Type { get; set; }
        public bool Required { get; set; }


        public virtual ICollection<Dialog> Dialogs { get; set; }
        public int SurveyId { get; set; }
    }   
}
