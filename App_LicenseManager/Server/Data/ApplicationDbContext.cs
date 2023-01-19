
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using App_LicenseManager.Shared.Models.Entities.Licenses;

namespace App_LicenseManager.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Tablas de mantenimiento de Licencias
        public DbSet<Employee> Employees { get; set; }
    }
}