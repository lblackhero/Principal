using Equitool.Models;
using EquiTool.Aplication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equitool.Controllers
{
    public class RolController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RolController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IFacturacion _IFacturacion;

        public RolController(RoleManager<IdentityRole> roleManager, ILogger<RolController> logger, UserManager<IdentityUser> userManager, IFacturacion IFacturacion)
        {
            _roleManager = roleManager;
            _logger = logger;
            _userManager = userManager;
            _IFacturacion = IFacturacion;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                RoleModel model = new RoleModel();
                model.roles = _roleManager.Roles.ToList();
                model.respuesta = null;

                return View("Index", model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario()
        {
            try
            {
                var Usuario = this.HttpContext.Request.Form["Usuario"];
                if (!string.IsNullOrEmpty(Usuario))
                {
                    _IFacturacion.GetUserByEMail(Usuario);
                }
                else
                {

                }

                RoleModel model = new RoleModel();
                model.roles = _roleManager.Roles.ToList();
                model.respuesta = null;

                return View("Index", model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }
    }
}
