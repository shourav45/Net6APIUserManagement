using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class ContactInfoDTO
    {
        public int Id { get; set; }
        public byte[]? Photo { get; set; }
        public string MemberName { get; set; } = null!;
        public string? Relation { get; set; }
        public string? Gender { get; set; }
        public string MobileNo1 { get; set; } = null!;
        public string? MobileNo2 { get; set; }
        public string? MobileNo3 { get; set; }
        public string? MobileNo4 { get; set; }
        public string? MobileNo5 { get; set; }
        public string? MobileNo6 { get; set; }
        public string? MailAddress1 { get; set; }
        public string? MailAddress2 { get; set; }
        public string? Country { get; set; }
        public DateTime? Dob { get; set; }
        public string? FacebookUrl { get; set; }
        public string? LinedinUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? NationalIdno { get; set; }
        public string? PassportNo { get; set; }
        public string? DrivingLicenceNo { get; set; }
        public string? Comment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
