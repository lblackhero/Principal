using Equitool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equitool.Models
{
    public class ModeloFacturacion
    {
        public List<fac_facturacion> listaRegistros { get; set; }

        public string respuestaError { get; set; }

    }
}
