
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


using App_LicenseManager.Shared.Models.Entities.Licenses;
using App_LicenseManager.Shared.Models.Entities;
using System.Data;

namespace App_LicenseManager.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

                     builder.Entity<LicRelAppModule>().HasKey(x => new { x.IdApplication, x.IdModule });

        }
        //Tablas 
        public DbSet<Employee> Employees { get; set; }
        #region LicencesManager

        public DbSet<LicApplication> LicApplications { get; set; }
        public DbSet<LicLicenceType> LicLicenceTypes { get; set; }
        public DbSet<LicModule> LicModules { get; set; }
        public DbSet<LicRelAppModule> LicRelAppModules { get; set; }

        #endregion
    }
}