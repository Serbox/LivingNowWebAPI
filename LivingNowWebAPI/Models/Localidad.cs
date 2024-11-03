using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingNowWebAPI.Models
{
    public class Localidad
    {
        [Key]
        public int idLocalidad { get; set; }
        public string nombre { get; set; }
        public int idCiudad  { get; set; }


        //navegacion a la entidad ciudad (relacion)
        [ForeignKey("idCiudad")]
        public Ciudad Ciudad { get; set; }
    }
}
