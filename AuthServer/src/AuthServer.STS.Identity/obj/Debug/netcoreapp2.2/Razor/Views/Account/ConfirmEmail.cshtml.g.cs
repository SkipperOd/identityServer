#pragma checksum "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a0a567cfb67b3adefa4792ebed9888e3cfd0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ConfirmEmail.cshtml", typeof(AspNetCore.Views_Account_ConfirmEmail))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Account\ConfirmEmail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a0a567cfb67b3adefa4792ebed9888e3cfd0a5", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f195b21669c3323ec15f5fcf6233d3b986e7a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
            BeginContext(132, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(139, 17, false);
#line 7 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(156, 31, true);
            WriteLiteral("</h1>\r\n<div>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(188, 27, false);
#line 10 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Account\ConfirmEmail.cshtml"
   Write(Localizer["ConfirmMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 20, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
