using Equitool.Data;
using EquiTool.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EquiTool.infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Tabla correspondiente a facturacion
        public DbSet<fac_facturacion> fac_facturacion { get; set; }

        //Tabla correspondiente a los tokens
        public DbSet<tok_tokengmail> tok_tokengmail { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder model_builder)
        {
            base.OnModelCreating(model_builder);
        }
    }
}