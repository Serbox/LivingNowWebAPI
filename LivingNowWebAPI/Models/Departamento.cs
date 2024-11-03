using System.ComponentModel.DataAnnotations;

namespace LivingNowWebAPI.Models
{
    public class Departamento
    {
        [Key]
        public int idDepartamento { get; set; }
        public string nombre { get; set; }
    }
}
