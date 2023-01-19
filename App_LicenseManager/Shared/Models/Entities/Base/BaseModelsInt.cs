
using System.ComponentModel.DataAnnotations;


namespace App_LicenseManager.Shared.Models.Entities.Base
{
    public class BaseModelsInt: BaseModelsAuditory
    {
        [Key]
        public long Id { get; set; } 

        [Required(ErrorMessage = "Campo {0} requerido"), StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }

       

    }
}
