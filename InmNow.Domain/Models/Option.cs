using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class Option
    {
        public Option()
        {
            this.AbstractOptions = new List<AbstractOption>();
            this.Options1 = new List<Option>();
        }

        public int OptionId { get; set; }
        public string Question { get; set; }
        public int Type { get; set; }
        public string QuestionDescription { get; set; }
        public int MeetingId { get; set; }
        public int? Option_OptionId { get; set; }
        public virtual ICollection<AbstractOption> AbstractOptions { get; set; }
        public virtual Meeting Meeting { get; set; }
        public virtual ICollection<Option> Options1 { get; set; }
        public virtual Option Option1 { get; set; }
    }
}
