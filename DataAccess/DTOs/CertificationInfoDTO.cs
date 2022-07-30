using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class CertificationInfoDTO
    {
        public int Id { get; set; }
        public string CertificateName { get; set; } = null!;
        public string? CertificateNo { get; set; }
        public DateTime CertifiedDate { get; set; }
        public string CertificationOrganisation { get; set; } = null!;
        public string? CertificationOrganisationUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
