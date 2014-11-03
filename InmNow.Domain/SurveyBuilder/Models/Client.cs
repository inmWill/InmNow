using System.Collections.Generic;
using InmNow.Domain.Base;
using InmNow.Domain.Models;

namespace InmNow.Domain.SurveyBuilder.Models
{
    public class Client : BaseEntity
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<InmUser> Users { get; set; } 
        public virtual ICollection<Survey> Surveys { get; set; } 
    }
}
