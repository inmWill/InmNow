using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class Option
    {
        public int OptionId { get; set; }
        public string Question { get; set; }
        public int Type { get; set; }
        public string QuestionDescription { get; set; }
        public int MeetingId { get; set; }
    }
}
