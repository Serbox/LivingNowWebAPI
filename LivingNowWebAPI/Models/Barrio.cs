using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingNowWebAPI.Models
{
    public class Barrio
    {
        [Key] 

        public int idBarrio { get; set; }
        public string nombre { get; set; }
        public int idLocalidad { get; set; }

        //Navegacion a la entidad Localidad (relacion)
        [ForeignKey("idLocalidad")]
        public Localidad Localidad { get; set; }
    }
}
