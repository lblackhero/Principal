using Equitool.Models;
using MailKit.Net.Imap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Equitool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        
        //private void GetCorreosUsuario()
        //{

        //    try
        //    {
        //        using (var client = new ImapClient())
        //        {
        //            using (var cancel = new CancellationTokenSource())
        //            {
        //                client.Connect("imap.gmail.com", 993, true, cancel.Token);
        //                client.AuthenticationMechanisms.Remove("XOAUTH");
        //                client.Authenticate(Input.Email, Input.Password);
        //                client.Inbox.Open(FolderAccess.ReadOnly);

        //                var mensajes = client.Inbox;

        //                List<fac_facturacion> lista = new List<fac_facturacion>();
        //                ClaimsPrincipal pr = this.User;
        //                var id = _userManager.GetUserId(pr);

        //                for (int i = 0; i < mensajes.Count; i++)
        //                {
        //                    var message = mensajes.GetMessage(i, cancel.Token);

        //                    lista.Add(new fac_facturacion()
        //                    {
        //                        Aspnet_UserId = "eee",
        //                        facb_estado = true,
        //                        facc_descripcion = message.Body.ToString(),
        //                        facc_repositorio = "",
        //                        facd_fechacreacion = DateTime.Now


        //                    });
        //                }

        //                _IFacturacion.Adfacturas(lista);

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
