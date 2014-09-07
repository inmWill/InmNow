using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class AspNetUser
    {
        public AspNetUser()
        {
            this.Abstracts = new List<Abstract>();
            this.AbstractUsers = new List<AbstractUser>();
            this.Affiliations = new List<Affiliation>();
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.AspNetRoles = new List<AspNetRole>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int? Type { get; set; }
        public string Discriminator { get; set; }
        public virtual ICollection<Abstract> Abstracts { get; set; }
        public virtual ICollection<AbstractUser> AbstractUsers { get; set; }
        public virtual ICollection<Affiliation> Affiliations { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
