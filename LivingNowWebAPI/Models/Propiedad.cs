using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingNowWebAPI.Models
{
    public class Propiedad
    {
        [Key]
        public int idPropiedad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string precio { get; set; }
        public int idBarrio { get; set; } 
        public int idTipoAccion { get; set; } 

        public int idUsuario {  get; set; }

        public string img {  get; set; }

        [ForeignKey("idBarrio")]
        public Barrio Barrio { get; set; }

        // Navegación a la entidad TipoAccion
        [ForeignKey("idTipoAccion")]
        public TipoAccion TipoAccion { get; set; }

        //Navegación a la entidad Usuarios 
        [ForeignKey("idUsuario")]
        public Usuario Usuario { get; set; }
    }
}
