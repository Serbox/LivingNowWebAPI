using System.ComponentModel.DataAnnotations;

namespace LivingNowWebAPI.Models
{
    public class Permiso
    {
        [Key]
        public int idPermiso { get; set; }
        public string nombrePermiso { get; set; }
    }
}
