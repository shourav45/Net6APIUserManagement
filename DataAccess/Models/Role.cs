using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedById { get; set; }
    }
}
