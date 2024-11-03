using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace LivingNowWebAPI.Models
{
    public class Ciudad
    {
        [Key]
        public int idCiudad { get; set; }
        public string nombre { get; set; }
        public int idDepartamento { get; set; }


        //navegacion para la entidad departamento (relacion)
        [ForeignKey("idDepartamento")]
        public Departamento Departamento { get; set; }
    }
}
