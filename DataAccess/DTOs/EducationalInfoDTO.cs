using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class EducationalInfoDTO
    {
        public int Id { get; set; }
        public string DegreeName { get; set; } = null!;
        public int? AcademicDurationYear { get; set; }
        public int? AcademicDurationMonth { get; set; }
        public DateTime PassingDate { get; set; }
        public decimal ResultScale { get; set; }
        public decimal ResultScore { get; set; }
        public string InstituteName { get; set; } = null!;
        public string? InstituteType { get; set; }
        public string? InstituteCountry { get; set; }
        public string? InstituteAddress { get; set; }
        public string? InstituteNo { get; set; }
        public string? InstituteUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
