#pragma checksum "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client\Section\Label.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a577c1740af57bc96260cbf3a341c6f090e4b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Client_Section_Label), @"mvc.1.0.view", @"/Views/Configuration/Client/Section/Label.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuration/Client/Section/Label.cshtml", typeof(AspNetCore.Views_Configuration_Client_Section_Label))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client\Section\Label.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a577c1740af57bc96260cbf3a341c6f090e4b5c", @"/Views/Configuration/Client/Section/Label.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f437c16c7d8a97b192ba089edebd2caf59fa6f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Client_Section_Label : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 27, false);
#line 5 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client\Section\Label.cshtml"
Write(Localizer[$"{Model}_Label"]);

#line default
#line hidden
            EndContext();
            BeginContext(125, 51, true);
            WriteLiteral("\r\n<span data-toggle=\"tooltip\" data-original-title=\"");
            EndContext();
            BeginContext(177, 26, false);
#line 6 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client\Section\Label.cshtml"
                                            Write(Localizer[$"{Model}_Info"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 76, true);
            WriteLiteral("\"><span style=\"font-size: 12px;\" class=\"oi oi-comment-square\"></span></span>");
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
