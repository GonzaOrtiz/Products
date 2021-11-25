using System.ComponentModel.DataAnnotations;

namespace FinalLabo.Models
{
    public class Producto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }
        //[Required(ErrorMessage = "El Precio obligatorio")]
        public float Precio { get; set; }
        //[Required(ErrorMessage = "La Descripcion obligatoria")]
        public string Descripcion { get; set; }
        //[Required(ErrorMessage = "La Imagen obligatoria")]
        public string Imagen { get; set; }
        public bool Favorito { get; set; }
        public int categoriaId { get; set; }
        public int marcaId { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
    }
}
