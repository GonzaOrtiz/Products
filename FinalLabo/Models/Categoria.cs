using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalLabo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Descripcion obligatoria")]
        public string Descripcion { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
