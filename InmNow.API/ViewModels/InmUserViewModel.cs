using System;

namespace InmNow.API.ViewModels
{
    public class InmUserViewModel
    {
        InmUserViewModel()
        {
            FullName = FirstName + " " + LastName;
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int Type { get; set; }
        public string FullName { get; set; }
    }
}