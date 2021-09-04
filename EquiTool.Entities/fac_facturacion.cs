using System;

namespace Equitool.Data
{
    /// <summary>
    /// Clase principal de facturación
    /// </summary>
    public class fac_facturacion
    {
        /// <summary>
        /// Id de la factura
        /// </summary>
        public int facn_id
        { get; set; }

        /// <summary>
        /// Descripción factura
        /// </summary>
        public string facc_descripcion
        { get; set; }

        /// <summary>
        /// Repositorio donde se va a almacenar la factura (Suele ser una ruta)
        /// </summary>
        public string facc_repositorio
        { get; set; }

        /// <summary>
        /// Id del usuario que realiza transacción
        /// </summary>
        public string Aspnet_UserId
        { get; set; }

        /// <summary>
        /// Estado de factura
        /// </summary>
        public bool facb_estado
        { get; set; }

        /// <summary>
        /// Fecha de creación factura
        /// </summary>
        public DateTime facd_creacion
        { get; set; }

        /// <summary>
        /// Fecha de actualización
        /// </summary>
        public DateTime facd_actualizacion
        { get; set; }
    }
}
