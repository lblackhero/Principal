﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MailKit.Net.Imap;
using System.Threading;
using MailKit;
using Equitool.Data;
using System.Security.Claims;
using EquiTool.Aplication;
using Microsoft.AspNetCore.Http;

namespace Equitool.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly IFacturacion _IFacturacion;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginModel(SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager, IFacturacion facturacion,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _IFacturacion = facturacion;
            _httpContextAccessor = httpContextAccessor;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "El email es obligatorio")]
            [EmailAddress]
            [Display(Name = "Correo electrónico")]
            public string Email { get; set; }

            [Required(ErrorMessage = "La contraseña es obligatoria")]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

            [Display(Name = "Recuerdame")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");

                    GetCorreosUsuario();

                    return LocalRedirect(returnUrl);

                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private void GetCorreosUsuario()
        {

            try
            {
                using (var client = new ImapClient())
                {
                    using (var cancel = new CancellationTokenSource())
                    {
                        client.Connect("imap.gmail.com", 993, true, cancel.Token);
                        client.AuthenticationMechanisms.Remove("XOAUTH");
                        client.Authenticate(Input.Email, Input.Password);
                        client.Inbox.Open(FolderAccess.ReadOnly);

                        _httpContextAccessor.HttpContext.Session.SetString("SessionVar", "Prueba!");

                        var mensajes = client.Inbox;

                        List<fac_facturacion> lista = new List<fac_facturacion>();
                        ClaimsPrincipal pr = this.User;
                        var id= _userManager.GetUserId(pr);

                        for (int i = 0; i < mensajes.Count; i++)
                        {
                            var message = mensajes.GetMessage(i, cancel.Token);

                            lista.Add(new fac_facturacion()
                            {
                                Aspnet_UserId = "eee",
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
