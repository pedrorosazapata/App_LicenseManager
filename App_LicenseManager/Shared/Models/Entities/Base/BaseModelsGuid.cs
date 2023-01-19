
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LicenseManager.Shared.Models.Entities.Base

{
    public class BaseModelsGuid: BaseModelsAuditory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Campo {0} requerido"), StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }

        
    }
}
