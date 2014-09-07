using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class AspNetUserClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string User_Id { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}