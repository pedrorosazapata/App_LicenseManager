
using App_LicenseManager.Server.Data;
using App_LicenseManager.Shared.Models.Entities.Licenses;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App_LicenseManager.Server.Controllers.Licenses
{
    [ApiController]
    [Route("[Controller]")]
    public class LicLicenceTypeController : Controller
    {
        private readonly ApplicationDbContext context;

        public LicLicenceTypeController(ApplicationDbContext _context)
        {
            context = _context;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<LicLicenceType>>> Get()
        {
            return await context.LicLicenceTypes.ToListAsync();
        }

        [HttpGet("{id}",Name = "obtenerLicenceType")]
        public async Task<ActionResult<LicLicenceType>> Get(int id)
        {
            return await context.LicLicenceTypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(LicLicenceType licLicenceType)
        {
            context.Entry(licLicenceType).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult> Post(LicLicenceType licLicenceType)
        {
            context.Add(licLicenceType);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerLicenceType", new { licLicenceType.Id }, licLicenceType);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var maeLicenceType=new LicLicenceType { Id = Id };
            context.Remove(maeLicenceType);
            
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
