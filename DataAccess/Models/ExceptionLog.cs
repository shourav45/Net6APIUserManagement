using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ExceptionLog
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int MenuId { get; set; }
        public string? ExceptionMessage { get; set; }
        public string? InnerException { get; set; }
        public string? ClassName { get; set; }
        public string? NameSpace { get; set; }
        public DateTime OccuredOn { get; set; }
        public bool? IsSolved { get; set; }
        public int? SolvedById { get; set; }
    }
}
