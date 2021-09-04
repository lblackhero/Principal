using Equitool.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System;
using EquiTool.Aplication;

namespace Equitool.Controllers
{
    public class FacturacionController : Controller
    {
        private readonly IFacturacion _IFacturacion;

        public FacturacionController(IFacturacion facturacion)
        {
             _IFacturacion= facturacion;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddFacturacion()
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                fac_facturacion fac_Facturacion = new fac_facturacion();
                fac_Facturacion.Aspnet_UserId = userId;
                fac_Facturacion.facb_estado = false;
                fac_Facturacion.facc_descripcion = "Prueba zozo";
                fac_Facturacion.facc_repositorio = "Prueba";
                fac_Facturacion.facd_fechacreacion = DateTime.Now;

                bool blnres = _IFacturacion.AddFacturacion(fac_Facturacion);

                return View();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
