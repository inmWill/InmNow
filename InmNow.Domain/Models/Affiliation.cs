using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class Affiliation
    {
        public int AffiliationId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string UserId { get; set; }
    }
}
