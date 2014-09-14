namespace InmNow.Domain.Models
{
    public class InmAbstractAuthor
    {
        public int InmAbstractAuthorId { get; set; }
        public bool Presenting { get; set; }
        public int DisplayOrder { get; set; }
        public int Type { get; set; }
        public bool hasAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int InmAbstract_Id { get; set; }
        public string UserId { get; set; }
    }
}
