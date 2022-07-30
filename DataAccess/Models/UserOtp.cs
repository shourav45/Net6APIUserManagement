using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserOtp
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? MailAddress { get; set; }
        public string? MobileNo { get; set; }
        public string? Otp { get; set; }
        public DateTime SentOn { get; set; }
        public DateTime? ExpireOn { get; set; }
        public bool IsValidated { get; set; }
    }
}
