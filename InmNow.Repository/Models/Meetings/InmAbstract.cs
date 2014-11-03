using InmNow.Repository.Models.Base;

namespace InmNow.Repository.Models
{
    public class InmAbstract : BaseEntity
    {
        public int InmAbstractId { get; set; }
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
        public string UserId { get; set; }
        public int? SessionId { get; set; }
    }
}
