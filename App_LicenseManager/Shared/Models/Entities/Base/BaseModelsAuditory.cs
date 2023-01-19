
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Base
{
    public class BaseModelsAuditory
    {
        [Required(ErrorMessage = "Campo {0} requerido")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Campo {0} requerido"), StringLength(20)]
        public string CreateUser { get; set; }
        [Required(ErrorMessage = "Campo {0} requerido")]
        public DateTime CreateDate { get; set; }

        [StringLength(20)]
        public string? ModifyUser { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(20)]
        public string? DeleteUser { get; set; }

        public DateTime? DeleteDate { get; set; }
        
        
        [StringLength(20)]
        public string? InActiveUser { get; set; }

        public DateTime? InActiveDate { get; set; }
    }
}
