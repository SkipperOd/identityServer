#pragma checksum "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71ba49425d6c85b0052e29387c0f73d4f1a71bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__StatusMessage), @"mvc.1.0.view", @"/Views/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_StatusMessage.cshtml", typeof(AspNetCore.Views_Manage__StatusMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71ba49425d6c85b0052e29387c0f73d4f1a71bc", @"/Views/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f195b21669c3323ec15f5fcf6233d3b986e7a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(136, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 140, "\"", 197, 4);
            WriteAttributeValue("", 148, "alert", 148, 5, true);
            WriteAttributeValue(" ", 153, "alert-", 154, 7, true);
#line 6 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 160, statusMessageClass, 160, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 179, "alert-dismissible", 180, 18, true);
            EndWriteAttribute();
            BeginContext(198, 150, true);
            WriteLiteral(" role=\"alert\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n    ");
            EndContext();
            BeginContext(349, 5, false);
#line 8 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Manage\_StatusMessage.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(354, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 10 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
