#pragma checksum "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca2cc092ce8461fe6b83424997dccebcb2220ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IdentityServerLink_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IdentityServerLink/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/IdentityServerLink/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_IdentityServerLink_Default))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca2cc092ce8461fe6b83424997dccebcb2220ae", @"/Views/Shared/Components/IdentityServerLink/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f437c16c7d8a97b192ba089edebd2caf59fa6f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_IdentityServerLink_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(95, 59, true);
            WriteLiteral("\r\n<a class=\"menu-item my-2 btn btn-outline-primary mr-md-3\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 154, "\"", 167, 1);
#line 5 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
WriteAttributeValue("", 161, Model, 161, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(170, 27, false);
#line 5 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
                                                                   Write(Localizer["IdentityServer"]);

#line default
#line hidden
            EndContext();
            BeginContext(197, 4, true);
            WriteLiteral("</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
