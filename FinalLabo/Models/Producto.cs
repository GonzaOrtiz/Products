using System.ComponentModel.DataAnnotations;

namespace FinalLabo.Models
{
    public class Producto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public bool Favorito { get; set; }
        public int categoriaId { get; set; }
        public int marcaId { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
    }
}
