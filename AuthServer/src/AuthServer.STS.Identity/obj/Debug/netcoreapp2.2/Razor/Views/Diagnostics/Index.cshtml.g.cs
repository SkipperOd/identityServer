#pragma checksum "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d3f37b7c9f47ba3e56a733a8e4d9d9ae0616b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnostics_Index), @"mvc.1.0.view", @"/Views/Diagnostics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Diagnostics/Index.cshtml", typeof(AspNetCore.Views_Diagnostics_Index))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d3f37b7c9f47ba3e56a733a8e4d9d9ae0616b8", @"/Views/Diagnostics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f195b21669c3323ec15f5fcf6233d3b986e7a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnostics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthServer.STS.Identity.ViewModels.Diagnostics.DiagnosticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(156, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(163, 18, false);
#line 5 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 13, true);
            WriteLiteral("</h1>\r\n\r\n<h3>");
            EndContext();
            BeginContext(195, 19, false);
#line 7 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Claims"]);

#line default
#line hidden
            EndContext();
            BeginContext(214, 13, true);
            WriteLiteral("</h3>\r\n<dl>\r\n");
            EndContext();
#line 9 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
     foreach (var claim in Model.AuthenticateResult.Principal.Claims)
	{

#line default
#line hidden
            BeginContext(299, 6, true);
            WriteLiteral("\t\t<dt>");
            EndContext();
            BeginContext(306, 10, false);
#line 11 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(316, 13, true);
            WriteLiteral("</dt>\r\n\t\t<dd>");
            EndContext();
            BeginContext(330, 11, false);
#line 12 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(341, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 13 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(352, 13, true);
            WriteLiteral("</dl>\r\n\r\n<h3>");
            EndContext();
            BeginContext(366, 23, false);
#line 16 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
Write(Localizer["Properties"]);

#line default
#line hidden
            EndContext();
            BeginContext(389, 13, true);
            WriteLiteral("</h3>\r\n<dl>\r\n");
            EndContext();
#line 18 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
     foreach (var prop in Model.AuthenticateResult.Properties.Items)
	{

#line default
#line hidden
            BeginContext(473, 6, true);
            WriteLiteral("\t\t<dt>");
            EndContext();
            BeginContext(480, 8, false);
#line 20 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(488, 13, true);
            WriteLiteral("</dt>\r\n\t\t<dd>");
            EndContext();
            BeginContext(502, 10, false);
#line 21 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(512, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 22 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(523, 9, true);
            WriteLiteral("</dl>\r\n\r\n");
            EndContext();
#line 25 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
 if (Model.Clients.Any())
{

#line default
#line hidden
            BeginContext(562, 5, true);
            WriteLiteral("\t<h3>");
            EndContext();
            BeginContext(568, 20, false);
#line 27 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
   Write(Localizer["Clients"]);

#line default
#line hidden
            EndContext();
            BeginContext(588, 14, true);
            WriteLiteral("</h3>\r\n\t<ul>\r\n");
            EndContext();
#line 29 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
         foreach (var client in Model.Clients)
		{

#line default
#line hidden
            BeginContext(649, 7, true);
            WriteLiteral("\t\t\t<li>");
            EndContext();
            BeginContext(657, 6, false);
#line 31 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
           Write(client);

#line default
#line hidden
            EndContext();
            BeginContext(663, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 32 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(675, 8, true);
            WriteLiteral("\t</ul>\r\n");
            EndContext();
#line 34 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Diagnostics\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthServer.STS.Identity.ViewModels.Diagnostics.DiagnosticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
