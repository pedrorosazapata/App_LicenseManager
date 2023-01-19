
using App_LicenseManager.Server.Data;
using App_LicenseManager.Shared.Models.Entities.Licenses;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App_LicenseManager.Server.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LicModulesController : Controller
    {
        private readonly ApplicationDbContext context;

        public LicModulesController(ApplicationDbContext _context)
        {
            context = _context;
        }
       
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<LicModule>>> Get()
        {
            return await context.LicModules.ToListAsync();
        }

        [HttpGet("{id}",Name = "obtenerModule")]
        public async Task<ActionResult<LicModule>> Get(int id)
        {
            return await context.LicModules.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(LicModule licModules)
        {
            context.Entry(licModules).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult> Post(LicModule licModules)
        {
            context.Add(licModules);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerModule", new { licModules.Id }, licModules);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var licModule=new LicModule { Id = Id };
            context.Remove(licModule);
            
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
