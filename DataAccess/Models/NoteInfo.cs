using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NoteInfo
    {
        public int Id { get; set; }
        public string? NoteTitle { get; set; }
        public string? NoteDetail { get; set; }
        public byte[]? NoteAttachment1 { get; set; }
        public byte[]? NoteAttachment2 { get; set; }
        public byte[]? NoteAttachment3 { get; set; }
        public byte[]? NoteAttachment4 { get; set; }
        public byte[]? NoteAttachment5 { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
