
using App_LicenseManager.Server.Data;
using App_LicenseManager.Shared.Models.Dto;
using App_LicenseManager.Shared.Models.Entities.Licenses;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLicences.Server.Controllers.Licenses
{
    [ApiController]
    [Route("[Controller]")]
    public class LicApplicationController : Controller
    {
        private readonly ApplicationDbContext context;

        public LicApplicationController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        //public async Task<ActionResult<LicAppVisualizarDTO>> Get(int id)
        //{
        //    var app = await context.LicApplications.Where(x => x.Id == id)
        //        .Include(x => x.LicRelAppModules).ThenInclude(x => x.IdModule)
        //                      .FirstOrDefaultAsync();

        //    if (app == null) { return NotFound(); }





        //    var model = new LicAppVisualizarDTO();
        //    model.LicApplication = app;
        //    model.LicModules = app.LicRelAppModules.Select(x => x.LicModules).ToList();



        //    return model;
        //}

        //[HttpGet("actualizar/{id}")]
        //public async Task<ActionResult<LicAppActualizacionDTO>> PutGet(int id)
        //{
        //    var maeAppActionResult = await Get(id);
        //    if (maeAppActionResult.Result is NotFoundResult) { return NotFound(); }

        //    var LicAppVisualizarDTO = maeAppActionResult.Value;
        //    var generosSeleccionadosIds = LicAppVisualizarDTO.LicModules.Select(x => x.Id).ToList();
        //    var generosNoSeleccionados = await context.LicModules
        //        .Where(x => !generosSeleccionadosIds.Contains(x.Id))
        //        .ToListAsync();

        //    var model = new LicAppActualizacionDTO();
        //    model.LicApp = LicAppVisualizarDTO.LicApplication;
        //    model.ModulesNoSeleccionados = generosNoSeleccionados;
        //    model.ModulesSeleccionados = LicAppVisualizarDTO.LicModules;

        //    return model;
        //}

        [HttpGet]
        public async Task<ActionResult<List<LicApplication>>> Get()
        {
            return await context.LicApplications.ToListAsync();
        }

        /*[HttpGet("{id}",Name = "obtenerApp")]
        public async Task<ActionResult<MaeApp>> Get(int id)
        {
            return await context.MaeApps.FirstOrDefaultAsync(x => x.Id == id);
        }*/

        [HttpPut]
        public async Task<ActionResult> Put(LicApplication licApp)
        {
            context.Entry(licApp).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult> Post(LicApplication licApp)
        {
            context.Add(licApp);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerApp", new { licApp.Id }, licApp);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var licApp=new LicApplication { Id = Id };
            context.Remove(licApp);
            
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
