using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingNowWebAPI.Models
{
    public class AccionVenta
    {

        [Key]
        public int idAccionVenta { get; set; }
        public string nombreAccion { get; set; }


    }
}
