using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string? MenuName { get; set; }
        public bool? IsParentMenu { get; set; }
        public int ParentMenuId { get; set; }
        public string? MenuUrl { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
