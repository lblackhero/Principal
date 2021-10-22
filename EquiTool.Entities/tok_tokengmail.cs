using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EquiTool.Entities
{
    /// <summary>
    /// Clase token para el usuario
    /// </summary>
    public class tok_tokengmail
    {
        /// <summary>
        /// ID del usuario que recibe el token
        /// </summary>
        [Key]
        public string aspnet_userid
        { get; set; }
        /// <summary>
        /// Token del usuario, codificado
        /// </summary>
        public string tokc_tokenusuario
        { get; set; }
        /// <summary>
        /// Fecha de referencia para cuando se creo el token - relación último ingreso, se renueva cada 60 minutos
        /// </summary>
        public DateTime tokd_fechacreacion
        { get; set; }
    }
}
