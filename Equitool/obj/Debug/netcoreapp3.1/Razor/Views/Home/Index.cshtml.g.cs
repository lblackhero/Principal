#pragma checksum "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c451978fbf1da4b9ea11de441aa3cfa4f3db93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\_ViewImports.cshtml"
using Equitool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\_ViewImports.cshtml"
using Equitool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c451978fbf1da4b9ea11de441aa3cfa4f3db93", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c474cfe1919851aaebd9569cd186229281237f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"bg-primary text-white text-center py-5\">\r\n        <div class=\"container-fluid py-3\">\r\n            <header class=\"mb-5\">\r\n                <h1 class=\"display-4 font-weight-bolder\"> Bienvenido ");
#nullable restore
#line 9 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml"
                                                                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <p class=""lead"">
                    Lorem ipsum met ed ta dolore.
                </p>
            </header>
            <svg class=""bi"" width=""32"" height=""32"" fill=""currentColor"">
                <use xlink:href=""lib/bootstrap-icons/bootstrap-icons.svg#person"" />
            </svg>
        </div>
    </section>
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    </div>
");
#nullable restore
#line 23 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center\">No se encuentra logeado por favor ingrese</p>\r\n");
#nullable restore
#line 27 "C:\Users\zozo\Source\Repos\Principal\Equitool\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591