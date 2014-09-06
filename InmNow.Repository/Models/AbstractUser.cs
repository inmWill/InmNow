using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class AbstractUser
    {
        public int AbstractUserId { get; set; }
        public bool Presenting { get; set; }
        public int DisplayOrder { get; set; }
        public int Type { get; set; }
        public bool hasAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AbstractId { get; set; }
        public string User_Id { get; set; }
        public string User_Id1 { get; set; }
        public virtual Abstract Abstract { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
