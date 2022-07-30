using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Permission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; } = null!;
        public bool? IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedById { get; set; }
    }
}
