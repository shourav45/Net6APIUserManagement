using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserBrowsingLog
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public int? MenuId { get; set; }
        public int? TotalVisitCount { get; set; }
        public DateTime LastVisitOn { get; set; }
    }
}
