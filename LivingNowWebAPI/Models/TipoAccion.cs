using System.ComponentModel.DataAnnotations;

namespace LivingNowWebAPI.Models
{
    public class TipoAccion
    {
        [Key]
        public int idTipoAccion { get; set; }
        public string nombre { get; set; } // Ejemplo: "Renta", "Venta"
    }
}
