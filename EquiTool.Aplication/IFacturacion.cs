using Equitool.Data;
using System.Collections.Generic;

namespace EquiTool.Aplication
{
    public interface IFacturacion
    {
        /// <summary>
        /// Metodo para agregar a la base de datos una factura.
        /// </summary>
        /// <param name="facturacion">estructura de base de datos requeria para agregar</param>
        /// <returns>Retorna un booleano indicando si la operación fue exitosa</returns>
        public bool AddFacturacion(fac_facturacion facturacion);

        public bool deleteFacturacion(fac_facturacion borrar);

        public bool updateFacturacion(fac_facturacion actualizar);

        public List<fac_facturacion> Adfacturas(List<fac_facturacion> facturasAgregar);
    }
}
