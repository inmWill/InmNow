﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmNow.Domain.Models
{
    public class Abstract
    {
        public Abstract()
        {
            this.AbstractOptions = new List<AbstractOption>();
            this.AbstractUsers = new List<AbstractUser>();
            this.Sessions = new List<Session>();
        }

        public int AbstractId { get; set; }
        public int Lognumber { get; set; }
        public bool IsLocked { get; set; }
        public int ActiveUserId { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Methods { get; set; }
        public string Results { get; set; }
        public string NovelAspect { get; set; }
        public System.DateTime PresentationDate { get; set; }
        public System.DateTime PublishDate { get; set; }
        public System.DateTime SubmittedDate { get; set; }
        public int PreferredTrackType { get; set; }
        public string AssignedSlot { get; set; }
        public string UploadedFile { get; set; }
        public int UploadedFileStatus { get; set; }
        public int LastUpdatedUserId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string UserId { get; set; }
        public int? SessionId { get; set; }
        public int? Session_SessionId { get; set; }
        public int? Session_SessionId1 { get; set; }
        public virtual ICollection<AbstractOption> AbstractOptions { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Session Session { get; set; }
        public virtual Session Session1 { get; set; }
        public virtual ICollection<AbstractUser> AbstractUsers { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
