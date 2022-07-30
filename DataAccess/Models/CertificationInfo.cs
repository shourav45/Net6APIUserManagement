using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CertificationInfo
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
