using App_LicenseManager.Shared.Models.Entities.Base;
using App_LicenseManager.Shared.Models.Entities.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Licenses
{
    public class LicApplication:BaseModelsInt
    {
        
        
        [Required(ErrorMessage = "Campo {0} requerido"), StringLength(10)]
        
        public string Version { get; set; }

        
        public List<LicRelAppModule> LicRelAppModules { get; set; }=new List<LicRelAppModule>();
        
    }
}
