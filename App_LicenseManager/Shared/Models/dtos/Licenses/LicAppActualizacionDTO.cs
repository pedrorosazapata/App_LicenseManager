using App_LicenseManager.Shared.Models.Entities;
using App_LicenseManager.Shared.Models.Entities.Licenses;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_LicenseManager.Shared.Models.Dto
{
    public class LicAppActualizacionDTO
    {
        public LicApplication LicApp { get; set; }
       
        public List<LicModule> ModulesSeleccionados { get; set; }
        public List<LicModule> ModulesNoSeleccionados { get; set; }
    }
}
