using FinalLabo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FinalLabo.ViewsModels
{
    public class ProductosViewModel
    {
        public List<Producto> Productos { get; set; }
        public SelectList Categorias { get; set; }
        public SelectList Marcas { get; set; }
        public string Nombre { get; set; }
    }
}
