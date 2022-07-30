using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AuditLog
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public string? PrimaryKeyId { get; set; }
        public string? ColumnName { get; set; }
        public string? ColumnOperation { get; set; }
        public string? PrevContent { get; set; }
        public string? UpdatedContent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
