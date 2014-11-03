using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using InmNow.Enums;
using InmNow.Repository.Models.Base;
using InmNow.Repository.Models.Survey;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InmNow.Repository.Models
{
    public class InmUser : IdentityUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public string Unit { get; set; }
        public string Region { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }

        public UserType Type { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        //authorization roles needed
    }
}
