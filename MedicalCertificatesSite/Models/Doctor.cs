using System;

namespace MedicalCertificatesSite.Models
{
    public class Doctor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
    }
}