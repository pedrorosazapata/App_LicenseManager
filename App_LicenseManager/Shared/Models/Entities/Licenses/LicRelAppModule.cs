using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Licenses
{
    public class LicRelAppModule
    {
        
        public int IdApplication { get; set; }
        
        public int IdModule { get; set; }
        public List<LicApplication> LicApplications { get; set; }
        public List<LicModule> LicModules { get; set; }
    }
}
