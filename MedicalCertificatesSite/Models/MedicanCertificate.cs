using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalCertificatesSite.Models
{
    public class MedicanCertificate
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual IdentityUser Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; } = DateTime.Now;
    }
}
