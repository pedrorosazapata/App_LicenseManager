
using App_LicenseManager.Shared.Models.Entities.Licenses;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_LicenseManager.Shared.Models.Dto
{
    public class LicAppVisualizarDTO
    {
        public LicApplication LicApplication { get; set; }
        public List<LicModule> LicModules { get; set; }
        
    }
}
