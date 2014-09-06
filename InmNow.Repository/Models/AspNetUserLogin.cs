using System;
using System.Collections.Generic;

namespace InmNow.Repository.Models
{
    public partial class AspNetUserLogin
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
