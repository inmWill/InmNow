using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class InmAbstractOption
    {
        public int InnmAbstractOptionId { get; set; }
        public string TextAnswer { get; set; }
        public bool? BoolAnswer { get; set; }
        public int? MultiAnswerId { get; set; }
        public int InmAbstractId { get; set; }
        public int OptionId { get; set; }
    }
}
