using System.ComponentModel.DataAnnotations;

namespace FinalLabo.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Domicilio obligatorio")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El Localidad obligatorio")]
        public string Localidad { get; set; }
        [Required(ErrorMessage = "El Provincia obligatorio")]
        public string Provincia { get; set; }
    }
}
