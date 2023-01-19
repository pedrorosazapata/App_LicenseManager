using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Licenses
{
    public class RelAppModules
    {
        
        public int IdApp { get; set; }
        
        public int IdModule { get; set; }
        public MaeApp MaeApps { get; set; }
        public MaeModules MaeModules { get; set; }
    }
}
