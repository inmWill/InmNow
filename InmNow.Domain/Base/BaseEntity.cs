using System;

namespace InmNow.Domain.Base
{
    public abstract class BaseEntity
    {
        public int? ModifiedById { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IpAddress { get; set; }
    }
}

