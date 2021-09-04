using Equitool.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EquiTool.infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Tabla correspondiente a facturacion
        public DbSet<fac_facturacion> fac_facturacion { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}