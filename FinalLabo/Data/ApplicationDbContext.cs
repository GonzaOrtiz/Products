using FinalLabo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<ProveedorProducto> proveedoresProductos { get; set; }
    }
}
