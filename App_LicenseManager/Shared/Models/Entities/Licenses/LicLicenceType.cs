using App_LicenseManager.Shared.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Licenses
{
    public class LicLicenceType:BaseModelsInt
    {
        
        [Required(ErrorMessage = "Campo {0} requerido")]
        public int NumEmp { get; set; } = 0;
        [Required(ErrorMessage = "Campo {0} requerido")]
        public int NumUsu { get; set; } = 0;
        
    }
}
