#pragma checksum "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c57e71fd8a5da7e6c62089c99cf8dd301a2d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Redirect), @"mvc.1.0.view", @"/Views/Shared/Redirect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Redirect.cshtml", typeof(AspNetCore.Views_Shared_Redirect))]
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
#line 2 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c57e71fd8a5da7e6c62089c99cf8dd301a2d31", @"/Views/Shared/Redirect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f195b21669c3323ec15f5fcf6233d3b986e7a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Redirect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthServer.STS.Identity.ViewModels.Account.RedirectViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signin-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(149, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(154, 18, false);
#line 4 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml"
Write(Localizer["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 10, true);
            WriteLiteral("</h1>\r\n<p>");
            EndContext();
            BeginContext(183, 21, false);
#line 5 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml"
Write(Localizer["SubTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(204, 32, true);
            WriteLiteral("</p>\r\n<meta http-equiv=\"refresh\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 236, "\"", 270, 2);
            WriteAttributeValue("", 246, "0;url=", 246, 6, true);
#line 6 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml"
WriteAttributeValue("", 252, Model.RedirectUrl, 252, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(271, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(283, 17, false);
#line 6 "D:\Test\AuthServer\src\AuthServer.STS.Identity\Views\Shared\Redirect.cshtml"
                                                                   Write(Model.RedirectUrl);

#line default
#line hidden
            EndContext();
            BeginContext(300, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
            BeginContext(304, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c57e71fd8a5da7e6c62089c99cf8dd301a2d315058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthServer.STS.Identity.ViewModels.Account.RedirectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
