using Equitool.Models;
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

        public RolController(RoleManager<IdentityRole> roleManager, ILogger<RolController> logger, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                RoleModel model = new RoleModel();
                model.roles = model.roles;
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
        public IActionResult AddUsuario()
        {
            try
            {
                var Usuario = this.HttpContext.Request.Form["Usuario"];

                RoleModel model = new RoleModel();
                model.roles = model.roles;
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
