namespace InmNow.Domain.Models
{
    public partial class InmUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int Type { get; set; }
    }
}
