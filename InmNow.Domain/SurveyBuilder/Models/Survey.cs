using System;
using System.Collections.Generic;
using InmNow.Domain.Base;
using InmNow.Domain.Models;

namespace InmNow.Domain.SurveyBuilder.Models
{
    public class Survey : BaseEntity
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string Instructions { get; set; }
        public string OtherInfo { get; set; }
        public bool IsRequired { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<InmUser> Users { get; set; } 
        public virtual ICollection<Question> Questions { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        // add relationship to organization  rename to survey?
    }
}
