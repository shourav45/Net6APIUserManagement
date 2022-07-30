using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserAccountCredentialLog
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public DateTime? ChangedOn { get; set; }
    }
}
