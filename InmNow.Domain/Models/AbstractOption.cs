using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class AbstractOption
    {
        public int AbstractOptionId { get; set; }
        public string Answer { get; set; }
        public int AbstractId { get; set; }
        public int OptionId { get; set; }
        public virtual Abstract Abstract { get; set; }
        public virtual Option Option { get; set; }
    }
}
