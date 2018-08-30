using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public string ProcessCode { get; set; }
        public string DataKey { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string MimeType { get; set; }
        public DateTime? AttachDate { get; set; }
        public string AttachBy { get; set; }
        public string SavedFileName { get; set; }
        public string FileExtension { get; set; }
        public string FileUniqueKey { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentType { get; set; }
        public string Remark { get; set; }
        public string AttachmentGroup { get; set; }
    }
}
