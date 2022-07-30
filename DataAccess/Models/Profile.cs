using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get; set; } = null!;
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Religion { get; set; }
        public string? BloodGroup { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? BirthCountry { get; set; }
        public string? LivingCountry { get; set; }
        public string? MaritalStatus { get; set; }
        public string? SpouseName { get; set; }
        public string? SpouseMobileNo { get; set; }
        public string Profession { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string? AlternativeMobileNo { get; set; }
        public string? NationalIdno { get; set; }
        public string? TincertificateNo { get; set; }
        public string? PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string? DrivingLicenceNo { get; set; }
    }
}
