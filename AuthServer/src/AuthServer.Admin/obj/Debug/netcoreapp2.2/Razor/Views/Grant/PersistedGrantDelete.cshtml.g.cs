#pragma checksum "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ff44923cd2e445ad569dde9b7e5b09a391a1cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grant_PersistedGrantDelete), @"mvc.1.0.view", @"/Views/Grant/PersistedGrantDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grant/PersistedGrantDelete.cshtml", typeof(AspNetCore.Views_Grant_PersistedGrantDelete))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ff44923cd2e445ad569dde9b7e5b09a391a1cf", @"/Views/Grant/PersistedGrantDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f437c16c7d8a97b192ba089edebd2caf59fa6f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Grant_PersistedGrantDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersistedGrantDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Grant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("client-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrantDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(252, 137, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-12\">\r\n\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t<ol class=\"breadcrumb\">\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(389, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ff44923cd2e445ad569dde9b7e5b09a391a1cf6395", async() => {
                BeginContext(445, 38, false);
#line 15 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                                                                                              Write(Localizer["NavigationPersistedGrants"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 39, true);
            WriteLiteral("</li>\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(526, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ff44923cd2e445ad569dde9b7e5b09a391a1cf8241", async() => {
                BeginContext(613, 15, false);
#line 16 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                                                                                                                             Write(Model.SubjectId);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                                                                                                    WriteLiteral(Model.SubjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(632, 66, true);
            WriteLiteral("</li>\r\n\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(699, 22, false);
#line 17 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                                                                  Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(721, 67, true);
            WriteLiteral("</li>\r\n\t\t\t</ol>\r\n\t\t</nav>\r\n\t</div>\r\n\r\n\t<div class=\"col-12\">\r\n\t\t<h2>");
            EndContext();
            BeginContext(789, 22, false);
#line 23 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
       Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(811, 26, true);
            WriteLiteral("</h2>\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(837, 894, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ff44923cd2e445ad569dde9b7e5b09a391a1cf11997", async() => {
                BeginContext(931, 5, true);
                WriteLiteral("\r\n\r\n\t");
                EndContext();
                BeginContext(936, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96ff44923cd2e445ad569dde9b7e5b09a391a1cf12385", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 29 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Key);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(973, 137, true);
                WriteLiteral("\r\n\r\n\t<div class=\"row table-responsive\">\r\n\t\t<div class=\"col-12\">\r\n\t\t\t<table class=\"table table-striped\">\r\n\t\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1111, 27, false);
#line 36 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Localizer["TableSubjectId"]);

#line default
#line hidden
                EndContext();
                BeginContext(1138, 16, true);
                WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1155, 22, false);
#line 37 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Localizer["TableType"]);

#line default
#line hidden
                EndContext();
                BeginContext(1177, 16, true);
                WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1194, 28, false);
#line 38 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Localizer["TableExpiration"]);

#line default
#line hidden
                EndContext();
                BeginContext(1222, 16, true);
                WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1239, 22, false);
#line 39 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Localizer["TableData"]);

#line default
#line hidden
                EndContext();
                BeginContext(1261, 16, true);
                WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1278, 24, false);
#line 40 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Localizer["TableClient"]);

#line default
#line hidden
                EndContext();
                BeginContext(1302, 66, true);
                WriteLiteral("</th>\r\n\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\r\n\t\t\t\t<tbody>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1369, 15, false);
#line 46 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Model.SubjectId);

#line default
#line hidden
                EndContext();
                BeginContext(1384, 16, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1401, 10, false);
#line 47 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Model.Type);

#line default
#line hidden
                EndContext();
                BeginContext(1411, 16, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1428, 16, false);
#line 48 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Model.Expiration);

#line default
#line hidden
                EndContext();
                BeginContext(1444, 16, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1461, 10, false);
#line 49 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Model.Data);

#line default
#line hidden
                EndContext();
                BeginContext(1471, 16, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1488, 14, false);
#line 50 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                   Write(Model.ClientId);

#line default
#line hidden
                EndContext();
                BeginContext(1502, 161, true);
                WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-12\">\r\n\t\t\t<button type=\"submit\" class=\"btn btn-danger\">");
                EndContext();
                BeginContext(1664, 30, false);
#line 59 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Grant\PersistedGrantDelete.cshtml"
                                                    Write(Localizer["ButtonDeleteGrant"]);

#line default
#line hidden
                EndContext();
                BeginContext(1694, 30, true);
                WriteLiteral("</button>\r\n\t\t</div>\r\n\t</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersistedGrantDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
