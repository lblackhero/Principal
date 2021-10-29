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
                //Obtengo listado de roles
                RoleModel model = new RoleModel();
                //Lo envio al modelo
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
        public async Task<IActionResult> AddUsuarioRol()
        {
            try
            {
                //Obtengo el usuario que viene desde el form
                var Usuario = this.HttpContext.Request.Form["CorreoUsuario"];
                //Obtengo el rol usuario que viene desde el form
                var RolUsuario = this.HttpContext.Request.Form["RolSeleccionado"];

                string strRespuesta = null;

                //Valido que los campos no esten vacios
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(RolUsuario))
                {
                    //Obtengo el usuario digitado
                    IdentityUser identityUser = _IFacturacion.GetUserByEMail(Usuario);
                    //Valido que el usuario exista
                    if (identityUser != null)
                    {
                        //Obtengo listado de roles del usuario y lo convierto a lista
                        List<string> lstResult = _userManager.GetRolesAsync(identityUser).Result.ToList();
                        //Valido que el rol seleccionado ya no lo tenga el usuario
                        if (!lstResult.Any(x => x.ToLower().Trim().Contains(RolUsuario)))
                        {
                            //Adiciono el rol al usuario
                            await _userManager.AddToRolesAsync(identityUser, RolUsuario);
                            strRespuesta = "0;Usuario adicionado al rol Correctamente";
                        }
                        else
                            strRespuesta = "1;El usuario ya se encuentra con el rol seleccionado";
                    }
                    else

                        strRespuesta = "1;El usuario digitado no se encuentra.";
                }
                else

                    strRespuesta = "1;Digite un usuario o seleccione rol.";

                //Retorno el modelo
                RoleModel model = new RoleModel();
                model.roles = _roleManager.Roles.ToList();
                model.respuesta = strRespuesta;

                return View("Index", model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult AddRol()
        {
            try
            {
                RoleModel model = new RoleModel();
                var rol = this.HttpContext.Request.Form["Rol"];
                if (!string.IsNullOrEmpty(rol))
                {
                    string strRespuesta = _IFacturacion.AddRol(rol);
                    model.respuesta = "0;" + strRespuesta;
                }
                else
                    model.respuesta = "1;Digite un rol valido";

                model.roles = _roleManager.Roles.ToList();

                return View("Index", model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }
        public IActionResult DeleteRol(string rol)
        {
            try
            {
                RoleModel model = new RoleModel();

                string strRespuesta = _IFacturacion.DeleteRol(rol);
                model.respuesta = "1;" + strRespuesta;

                model.roles = _roleManager.Roles.ToList();

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
