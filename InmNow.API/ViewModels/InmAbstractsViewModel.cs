using System;

namespace InmNow.API.ViewModels
{
    public class InmAbstractsViewModel
    {
        InmAbstractsViewModel()
        {
            Proof = "I'm a view model!";
        }

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
        public DateTime PresentationDate { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime SubmittedDate { get; set; }
        public int PreferredTrackType { get; set; }
        public string AssignedSlot { get; set; }
        public string UploadedFile { get; set; }
        public int UploadedFileStatus { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string UserId { get; set; }
        public int? SessionId { get; set; }
        public string Proof { get; set; }
    }
}