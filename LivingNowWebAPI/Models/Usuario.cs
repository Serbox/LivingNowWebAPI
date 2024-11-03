using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingNowWebAPI.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int idRol { get; set; }

        //relacion foren key con el rol 
        [ForeignKey("idRol")]
        public Rol Rol { get; set; }    
    }
}
