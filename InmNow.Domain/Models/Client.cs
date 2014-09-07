using System;
using System.Collections.Generic;

namespace InmNow.Domain.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string URL { get; set; }
    }
}
