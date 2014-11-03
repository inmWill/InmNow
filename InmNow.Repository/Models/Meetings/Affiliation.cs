using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class Affiliation : BaseEntity
    {
        public int AffiliationId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Street { get; set; }
        public string Unit { get; set; }
        public string Region { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
    }
}
