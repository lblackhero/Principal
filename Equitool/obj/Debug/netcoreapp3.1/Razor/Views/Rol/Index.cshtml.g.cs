#pragma checksum "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e910ec4be9894cb757540ae75c0d4a5dfe3c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rol_Index), @"mvc.1.0.view", @"/Views/Rol/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\zozo\source\repos\Principal\Equitool\Views\_ViewImports.cshtml"
using Equitool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zozo\source\repos\Principal\Equitool\Views\_ViewImports.cshtml"
using Equitool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e910ec4be9894cb757540ae75c0d4a5dfe3c20", @"/Views/Rol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c474cfe1919851aaebd9569cd186229281237f", @"/Views/_ViewImports.cshtml")]
    public class Views_Rol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equitool.Models.RoleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-custom btn-primary btn-block btn-lg text-sm-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUsuarioRol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-custom btn-primary rounded-0 btn-block btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnAddRol"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addRolForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-custom btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("btnBorrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
  
    ViewData["Title"] = "Gestionar roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
 if (this.User.IsInRole("Administrador"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"container\">\r\n        <h2 class=\"text-center text-dark p-2 bg-white headings__boxshadow--dark\"> ");
#nullable restore
#line 11 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                                                             Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""container justify-content-center align-items-center mt-4"">
        <!-- Nav navigation -->
        <div role=""tablist"" aria-owns=""pills-home-tab pills-profile-tab"">
            <ul class=""nav nav-pills nav-fill flex-column flex-sm-row justify-content-center nav-pills__nav-item--boxShadow"" id=""pills-tab"" role=""tablist"">
                <li class=""nav-item"" role=""presentation"">
                    <a class=""nav-link active"" id=""pills-home-tab"" data-toggle=""pill"" href=""#pills-home"" role=""tab""
                       aria-controls=""pills-home"" aria-selected=""true"">
                        <i class=""fas fa-user-edit""></i> Dar un rol a un usuario
                    </a>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <a class=""nav-link"" id=""pills-profile-tab"" data-toggle=""pill"" href=""#pills-profile"" role=""tab""
                       aria-controls=""pills-profile"" aria-selected=""false"">
                        <i class=""fas fa-plus""></i>");
            WriteLiteral(@" Crear un nuevo rol
                    </a>
                </li>
            </ul>
        </div>

        <!-- Tab content -->

        <div class=""tab-content"" id=""pills-tabContent"">
            <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab"">
                <div class=""raised-blocks"">
                    <!-- FORMULARIO DAR ROL A UN USUARIO -->
                    <div class=""col border p-xl-5 p-lg-4 p-md-3 p-sm-2 mt-3 mb-5"">
                        <h3 class=""text-center"">Dar rol a un usuario</h3>
                        <hr />
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c209778", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label>Dígite usuario</label>
                                <input type=""text"" class=""form-control shadow-none"" placeholder=""Dígite correo"" required name=""CorreoUsuario"" />
                            </div>
                            <div class=""form-group"">
                                <div class=""checkbox"">
");
#nullable restore
#line 50 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                     foreach (var item in Model.roles)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"form-check\">\r\n                                            <input class=\"form-check-input\"\r\n                                                   type=\"radio\"");
                BeginWriteAttribute("value", "\r\n                                                   value=\"", 2707, "\"", 2777, 1);
#nullable restore
#line 55 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
WriteAttributeValue("", 2767, item.Name, 2767, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                                   id=""flexCheckDefault""
                                                   name=""RolSeleccionado"" />
                                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                                ");
#nullable restore
#line 59 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </label>\r\n                                        </div>\r\n");
#nullable restore
#line 62 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c2012451", async() => {
                    WriteLiteral("Adicionar usuario a rol");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- FIN FORMULARIO ROL A USUARIO -->
                </div>
            </div>

            <div class=""tab-pane fade"" id=""pills-profile"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"">
                <!-- FORMULARIO CREAR ROL -->
                <div class=""col border p-xl-5 p-lg-4 p-md-3 p-sm-2 mt-3 mb-5"">
                    <h3 class=""text-center"">Añadir un nuevo rol</h3>
                    <hr />
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c2015619", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""NombreRol"">Rol</label>
                            <input type=""text"" class=""form-control shadow-none"" id=""NombreRol"" name=""Rol"" placeholder=""Rol a adicionar"" required>
                        </div>
                        <div class=""form-group"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c2016264", async() => {
                    WriteLiteral("Adicionar Rol");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <!-- FIN FORMULARIO CREAR ROL -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <!-- DATATABLE -->\r\n");
            WriteLiteral(@"    <div class=""container border p-3 mb-3"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""table-responsive table-hover"">
                    <table id=""tablaRoles"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
                        <thead class=""text-center"">
                            <tr>
                                <th>Nombre del rol</th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody class=""text-center"">
");
#nullable restore
#line 108 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                             foreach (var item in Model.roles)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 112 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        <!-- Borrar -->\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c2020770", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e910ec4be9894cb757540ae75c0d4a5dfe3c2021073", async() => {
                    WriteLiteral("<i class=\"fas fa-trash-alt\"></i><span class=\"hidden-small\"> Borrar</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6044, "showMessageDelete(", 6044, 18, true);
#nullable restore
#line 117 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
AddHtmlAttributeValue("", 6062, Model.respuesta, 6062, 16, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6078, ")", 6078, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-rol", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                                                                                                                                                                             WriteLiteral(item.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["rol"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rol", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["rol"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n");
#nullable restore
#line 121 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 128 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        // llamar al dataTable
        $(document).ready(function () {
            var table = $('#tablaRoles').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.11.3/i18n/es_es.json""
                },
                responsive: true,

            });

            new $.fn.dataTable.FixedHeader(table);

            const Toast = Swal.mixin({
                toast: true,
                position: 'bottom-end',
                showConfirmButton: false,
                timer: 5000,
                timerProgressBar: true,
                didOpen: (toast) => {
                    toast.addEventListener('mouseenter', Swal.stopTimer)
                    toast.addEventListener('mouseleave', Swal.resumeTimer)
                }
            })

            if ('");
#nullable restore
#line 158 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
            Write(Html.Raw(@Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != \'\' && \'");
#nullable restore
#line 158 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                                   Write(Html.Raw(@Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != null && \'");
#nullable restore
#line 158 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                                                                                            Write(Html.Raw(@Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != undefined) {\r\n                var respuesta = \'");
#nullable restore
#line 159 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                            Write(Html.Raw(Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                var validador = respuesta.split(\';\')[0];\r\n                if (validador == 0) {\r\n                    Toast.fire({\r\n                        title: \'");
#nullable restore
#line 163 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                           Write(Html.Raw(Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'.split(\';\')[1],\r\n                        icon: \'success\'\r\n                    })\r\n                }\r\n                else if (validador == 1) {\r\n                    Toast.fire({\r\n                        title: \'");
#nullable restore
#line 169 "C:\Users\zozo\source\repos\Principal\Equitool\Views\Rol\Index.cshtml"
                           Write(Html.Raw(Model.respuesta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'.split(\';\')[1],\r\n                        icon: \'warning\'\r\n                    })\r\n                }\r\n            }\r\n\r\n\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equitool.Models.RoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
