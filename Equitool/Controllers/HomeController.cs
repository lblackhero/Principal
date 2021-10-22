﻿using Equitool.Data;
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
        private readonly ITokenGmail _tokenGmail;
        private readonly SignInManager<IdentityUser> _signInManager;


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
            if (User.Identity.IsAuthenticated)
            {
                

                if (!GetCorreosUsuario())
                {

                    ModeloFacturacion modelFacturation = new ModeloFacturacion();

                    modelFacturation.listaRegistros = new List<fac_facturacion>();

                    modelFacturation.respuestaError = null;

                    await _signInManager.SignOutAsync();

                    return View("Index", modelFacturation);
                }

            }

            var userId = this.User.FindFirstValue( ClaimTypes.NameIdentifier);

            ModeloFacturacion modeloFacturacion = new ModeloFacturacion();

            modeloFacturacion.listaRegistros = _IFacturacion.GetFacturacion(userId);

            modeloFacturacion.respuestaError = null;

            return View("Index", modeloFacturacion);
        }
        private bool GetCorreosUsuario()
        {

            bool variable = true;

            try
            {

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (_httpContextAccessor.HttpContext.Session.GetString("SessionVar") == null)
                {

                    var tokenUserID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    var resultado = _tokenGmail.GetTokenUsuario(tokenUserID);

                    if (resultado != null)
                    {
                        _httpContextAccessor.HttpContext.Session.SetString("SessionVar", resultado.tokc_tokenusuario);
                    }
                    else
                    {
                        variable = false;
                    }
                }
                else
                {
                    tok_tokengmail Token = new tok_tokengmail();

                    Token.aspnet_userid = userId;
                    Token.tokc_tokenusuario = _IFacturacion.Base64Encode(_httpContextAccessor.HttpContext.Session.GetString("SessionVar"));
                    Token.tokd_fechacreacion = DateTime.Now;

                    bool resultado = _tokenGmail.AddToken(Token);
                }

                if (variable)
                {
                    string contraseña = _httpContextAccessor.HttpContext.Session.GetString("SessionVar");

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

            }
            catch (Exception)
            {
                variable = false;
            }

            return variable;

        }
        
    }
}
