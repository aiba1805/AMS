using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AMS.Core.Models;

namespace AMS.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<UNT> Unts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AMS;Username=postgres;Password=postgres");
    }
}
