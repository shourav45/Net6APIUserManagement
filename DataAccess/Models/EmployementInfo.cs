using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EmployementInfo
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string EmploymentType { get; set; } = null!;
        public string JoiningDesignation { get; set; } = null!;
        public string LastDesignation { get; set; } = null!;
        public string JoiningDepartment { get; set; } = null!;
        public string LastDepartment { get; set; } = null!;
        public DateTime DateOfJoin { get; set; }
        public DateTime? DateOfSeparation { get; set; }
        public string? CompanyUrl { get; set; }
        public string CompanyCountry { get; set; } = null!;
        public string? CompanyCity { get; set; }
        public string? CompanyAddress { get; set; }
        public string? RemunerationCurrency { get; set; }
        public int? GrossRemunerationPerMonth { get; set; }
        public string? Comment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
