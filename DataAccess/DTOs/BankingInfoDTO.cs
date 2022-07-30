using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class BankingInfoDTO
    {
        public int Id { get; set; }
        [Required]
        public string BankName { get; set; } = null!;
        public string? CardType { get; set; }
        public string? CardNo { get; set; }
        [Required]
        public string AccountNo { get; set; } = null!;
        [Required]
        public string BankBranch { get; set; } = null!;
        public string? SwiftCode { get; set; }
        public string? RouteNo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
