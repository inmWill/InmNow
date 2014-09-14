namespace InmNow.Repository.Models
{
    public partial class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public UserType Type { get; set; }
    }
}
