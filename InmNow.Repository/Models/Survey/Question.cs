using System.Collections.Generic;
using InmNow.Enums;
using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models.Survey
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
