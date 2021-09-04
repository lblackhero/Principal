using System;
using System.Linq;
using Equitool.Data;
using EquiTool.Aplication;
using EquiTool.infrastructure;

namespace EquiTool.Domain
{
    public class Facturacion : IFacturacion
    {

        private readonly ApplicationDbContext _context;

        public Facturacion(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo para agregar a la base de datos una factura.
        /// </summary>
        /// <param name="facturacion">estructura de base de datos requeria para agregar</param>
        /// <returns>Retorna un booleano indicando si la operación fue exitosa</returns>
        public bool AddFacturacion(fac_facturacion facturacion)
        {
            try
            {
                var result = _context.fac_facturacion.Any(x => x.facn_id > 0);
                if (result)
                    facturacion.facn_id = (_context.fac_facturacion.ToList().LastOrDefault().facn_id + 1);
                else
                    facturacion.facn_id = 1;

                _context.fac_facturacion.Add(facturacion);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
