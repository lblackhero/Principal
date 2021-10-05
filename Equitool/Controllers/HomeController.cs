using Equitool.Data;
using Equitool.Models;
using EquiTool.Aplication;
using MailKit;
using MailKit.Net.Imap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Equitool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private object _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IFacturacion _IFacturacion;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, IFacturacion facturacion)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _IFacturacion = facturacion;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                //GetCorreosUsuario();
            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private void GetCorreosUsuario()
        {

            try
            {

                string contraseña = _httpContextAccessor.HttpContext.Session.GetString("SessionVar");
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);


                using (var client = new ImapClient())
                {
                    using (var cancel = new CancellationTokenSource())
                    {
                        client.Connect("imap.gmail.com", 993, true, cancel.Token);
                        client.AuthenticationMechanisms.Remove("XOAUTH");
                        client.Authenticate(this.User.Identity.Name, _IFacturacion.Base64Decode(contraseña));
                        client.Inbox.Open(FolderAccess.ReadOnly);



                        var mensajes = client.Inbox;

                        List<fac_facturacion> lista = new List<fac_facturacion>();

                        for (int i = 0; i < mensajes.Count; i++)
                        {
                            var message = mensajes.GetMessage(i, cancel.Token);

                            lista.Add(new fac_facturacion()
                            {
                                Aspnet_UserId = userId,
                                facb_estado = true,
                                facc_descripcion = message.Body.ToString(),
                                facc_repositorio = "",
                                facd_fechacreacion = DateTime.Now


                            });
                        }

                        _IFacturacion.Adfacturas(lista);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
