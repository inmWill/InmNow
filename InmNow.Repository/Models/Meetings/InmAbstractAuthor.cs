using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class InmAbstractAuthor : BaseEntity
    {
        public int InmAbstractAuthorId { get; set; }
        public bool Presenting { get; set; }
        public int DisplayOrder { get; set; }
        public int Type { get; set; }
        public bool hasAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int InmAbstractId { get; set; }
        public string UserId { get; set; }
    }
}
