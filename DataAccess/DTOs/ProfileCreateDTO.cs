using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class ProfileCreateDTO
    {
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get; set; } = null!;
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Profession { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
    }
}
