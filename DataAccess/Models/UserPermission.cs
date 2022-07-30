using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int MenuId { get; set; }
        public int PermissionId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
