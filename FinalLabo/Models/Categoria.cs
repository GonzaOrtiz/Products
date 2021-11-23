using System.Collections.Generic;

namespace FinalLabo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
