using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? UserPassword { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? RoleId { get; set; }
    }
}
