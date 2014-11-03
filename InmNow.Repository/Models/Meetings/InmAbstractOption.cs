using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class InmAbstractOption : BaseEntity
    {
        public int InmAbstractOptionId { get; set; }
        public string TextAnswer { get; set; }
        public bool? BoolAnswer { get; set; }
        public int? MultiAnswerId { get; set; }
        public int InmAbstractId { get; set; }
        public int OptionId { get; set; }
    }
}
