
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App_LicenseManager.Shared.Models;
using App_LicenseManager.Shared.Models.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace App_LicenseManager.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext//IdentityDbContextApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public ApplicationDbContext(
        //    DbContextOptions options,
        //    IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        //{
        //}
        public DbSet<Employee> Employees { get; set; }
    }
}