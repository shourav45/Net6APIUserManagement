using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BankingInfo
    {
        public int Id { get; set; }
        public string BankName { get; set; } = null!;
        public string? CardType { get; set; }
        public string? CardNo { get; set; }
        public string AccountNo { get; set; } = null!;
        public string BankBranch { get; set; } = null!;
        public string? SwiftCode { get; set; }
        public string? RouteNo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
