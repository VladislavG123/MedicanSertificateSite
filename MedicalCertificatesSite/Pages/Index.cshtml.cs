using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedicalCertificatesSite.Data;
using MedicalCertificatesSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MedicalCertificatesSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;


        }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public List<Doctor> Doctors { get; set; }

        [BindProperty]
        public Doctor CurrentDoctor { get; set; }

        public void OnGet()
        {
            Doctors = context.Doctors.ToList();
        }

        public ActionResult OnPost()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            if (user is null)
                return NotFound();


            context.MedicanCertificates.Add(new MedicanCertificate
            {
                Doctor = this.CurrentDoctor,
                Description = Description,
                Patient = user
            });
            context.SaveChanges();

            return Redirect("Ok");
        }

    }
}
