
using System.ComponentModel.DataAnnotations;


namespace App_LicenseManager.Shared.Models.Entities.Base
{
    public class BaseModelsString: BaseModelsAuditory
    {
        [Key,StringLength(50)]
        public string Id { get; set; } = "";

        [Required(ErrorMessage = "Campo {0} requerido"), StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }

       

    }
}
