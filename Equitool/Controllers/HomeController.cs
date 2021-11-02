using Equitool.Data;
using Equitool.Models;
using EquiTool.Aplication;
using EquiTool.Entities;
using MailKit;
using MailKit.Net.Imap;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
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
        private readonly ITokenGmail _tokenGmail;
        private readonly SignInManager<IdentityUser> _signInManager;
        private Task _status;


        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, IFacturacion facturacion, ITokenGmail tokenGmail, SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _IFacturacion = facturacion;
            _tokenGmail = tokenGmail;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    if (_httpContextAccessor.HttpContext.Session.GetString("IsFirstLogin") != null)
                    {
                        if (_httpContextAccessor.HttpContext.Session.GetString("IsFirstLogin").ToString().Equals("OK"))
                        {
                            tok_tokengmail Token = new tok_tokengmail();
                            Token.aspnet_userid = userId;
                            Token.tokc_tokenusuario = _IFacturacion.Base64Encode(_httpContextAccessor.HttpContext.Session.GetString("SessionVar"));
                            Token.tokd_fechacreacion = DateTime.Now;
                            bool resultado = _tokenGmail.AddToken(Token);

                        }
                    }
                    if (!GetCorreosUsuario(userId))
                    {
                        ModeloFacturacion modelFacturation = new ModeloFacturacion();
                        modelFacturation.listaRegistros = new List<fac_facturacion>();
                        modelFacturation.respuestaError = null;
                        await _signInManager.SignOutAsync();
                        HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);

                        return View("Index", modelFacturation);
                    }
                    else
                    {
                        ModeloFacturacion modeloFacturacion = new ModeloFacturacion();
                        modeloFacturacion.listaRegistros = new List<fac_facturacion>();
                        modeloFacturacion.respuestaError = null;

                        return View("Index", modeloFacturacion);
                    }
                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        private bool GetCorreosUsuario(string userId)
        {
            bool variable = true;
            tok_tokengmail token = new tok_tokengmail();
            try
            {

                if (_httpContextAccessor.HttpContext.Session.GetString("SessionVar") == null)
                {
                    token = _tokenGmail.GetTokenUsuario(userId);
                    if (token.tokd_fechacreacion.AddMinutes(45) > DateTime.Now)
                    {
                        if (token != null)
                            _httpContextAccessor.HttpContext.Session.SetString("SessionVar", _IFacturacion.Base64Decode(token.tokc_tokenusuario));
                        else
                            variable = false;
                        string contraseña = _httpContextAccessor.HttpContext.Session.GetString("SessionVar");
                        _status = AddCorreosAsync(this.User.Identity.Name, contraseña, userId);
                        while (!_status.IsCompleted) { };
                    }
                    else
                        variable = false;
                }
                else
                {
                    if (_httpContextAccessor.HttpContext.Session.GetString("IsFirstLogin") != null)
                    {
                        if (_httpContextAccessor.HttpContext.Session.GetString("IsFirstLogin").ToString().Equals("OK"))
                        {
                            _httpContextAccessor.HttpContext.Session.SetString("IsFirstLogin", "BAD");
                            string contraseña = _httpContextAccessor.HttpContext.Session.GetString("SessionVar");
                            _status = AddCorreosAsync(this.User.Identity.Name, contraseña, userId);
                            while (!_status.IsCompleted) { };
                        }
                    }
                }
            }
            catch
            {
                variable = false;
            }
            return variable;
        }

        private Task AddCorreosAsync(string userName, string strContraseña, string userId)
        {
            try
            {
                return Task.Run(() =>
                {
                    using (var client = new ImapClient())
                    {
                        using (var cancel = new CancellationTokenSource())
                        {
                            client.Connect("imap.gmail.com", 993, true, cancel.Token);
                            client.AuthenticationMechanisms.Remove("XOAUTH");
                            client.Authenticate(userName, strContraseña);
                            client.Inbox.Open(FolderAccess.ReadOnly);
                            var mensajes = client.Inbox;

                            List<fac_facturacion> lista = new List<fac_facturacion>();
                            for (int i = 0; i < mensajes.Count; i++)
                            {
                                var message = mensajes.GetMessage(i, cancel.Token);
                                bool blnresult = false;
                                string ruta = null;
                                if (message.Attachments.Count() > 0)
                                {
                                    foreach (var attachment in message.Attachments)
                                    {
                                        string name = Guid.NewGuid().ToString();
                                        if (!System.IO.Directory.Exists(@"C:\Adjunto\"))
                                            System.IO.Directory.CreateDirectory(@"C:\Adjunto\");
                                        if (ruta == null)
                                            ruta = @"C:\Adjunto\" + name + "." + attachment.ContentType.MediaSubtype;
                                        else
                                            ruta += ";" + @"C:\Adjunto\" + name + "." + attachment.ContentType.MediaSubtype;

                                        using (var stream = System.IO.File.Create(@"C:\Adjunto\" + name + "." + attachment.ContentType.MediaSubtype))
                                        {
                                            if (attachment is MessagePart)
                                            {
                                                var part = (MessagePart)attachment;
                                                part.Message.WriteTo(stream);
                                            }
                                            else
                                            {
                                                var part = (MimePart)attachment;
                                                part.Content.DecodeTo(stream);
                                            }
                                        }
                                    }
                                    blnresult = true;
                                }
                                if (blnresult)
                                {
                                    lista.Add(new fac_facturacion()
                                    {
                                        Aspnet_UserId = userId,
                                        facb_estado = true,
                                        facc_descripcion = string.IsNullOrEmpty(message.TextBody == "" ? null : message.TextBody) ? ("Sin Descripción") : message.TextBody,
                                        facc_repositorio = ruta,
                                        facd_fechacreacion = DateTime.Now,
                                        facc_desde = message.From.ToString(),
                                        facc_para = message.To.ToString(),
                                        facc_idcorreounico = message.MessageId.ToString()
                                    });
                                }
                            }
                            if (lista.Count > 0)
                                _IFacturacion.Adfacturas(lista);
                        }
                    }
                });
            }
            catch
            {
                throw;
            }
        }

        public IActionResult GetCorreos()
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                ModeloFacturacion modeloFacturacion = new ModeloFacturacion();

                modeloFacturacion.listaRegistros = _IFacturacion.GetFacturacion(userId);
                modeloFacturacion.respuestaError = null;

                return View("Index", modeloFacturacion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        public IActionResult VerDetallado(string id)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                ModeloFacturacion modeloFacturacion = new ModeloFacturacion();
                modeloFacturacion.listaRegistros = _IFacturacion.GetFacturacion(userId);
                modeloFacturacion.respuestaError = null;
                modeloFacturacion.registroModal = _IFacturacion.GetFacturacionById(Convert.ToInt32(id));
                return View("Index", modeloFacturacion);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
