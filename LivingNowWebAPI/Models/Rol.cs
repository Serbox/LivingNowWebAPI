using System.ComponentModel.DataAnnotations;

namespace LivingNowWebAPI.Models
{
    public class Rol
    {
        [Key]
        public int idRol { get; set; }
        public string nombreRol { get; set; }
    }
}
