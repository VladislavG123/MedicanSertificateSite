using System;
using System.Collections.Generic;
using System.Text;
using MedicalCertificatesSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalCertificatesSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicanCertificate> MedicanCertificates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Doctor>().HasData(
                new Doctor
                {
                    FullName = "Иван Петрович"
                },
                new Doctor
                {
                    FullName = "Петр Иванович"
                },
                new Doctor
                {
                    FullName = "Григорий Григорьевич"
                });
        }
    }
}
