#pragma checksum "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fbbd746ff3784ffaa1df5a3203575f7adeb2c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Client), @"mvc.1.0.view", @"/Views/Configuration/Client.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuration/Client.cshtml", typeof(AspNetCore.Views_Configuration_Client))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fbbd746ff3784ffaa1df5a3203575f7adeb2c7", @"/Views/Configuration/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f437c16c7d8a97b192ba089edebd2caf59fa6f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Configuration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("client-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(236, 880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fbbd746ff3784ffaa1df5a3203575f7adeb2c75795", async() => {
                BeginContext(324, 144, true);
                WriteLiteral("\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-12\">\r\n\t\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t\t<ol class=\"breadcrumb\">\r\n\t\t\t\t\t<li class=\"breadcrumb-item\">");
                EndContext();
                BeginContext(468, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fbbd746ff3784ffaa1df5a3203575f7adeb2c76355", async() => {
                    BeginContext(524, 30, false);
#line 16 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
                                                                                                  Write(Localizer["NavigationClients"]);

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
                BeginContext(558, 67, true);
                WriteLiteral("</li>\r\n\t\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
                EndContext();
                BeginContext(626, 14, false);
#line 17 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
                                                                      Write(Model.ClientId);

#line default
#line hidden
                EndContext();
                BeginContext(640, 41, true);
                WriteLiteral("</li>\r\n\t\t\t\t</ol>\r\n\t\t\t</nav>\r\n\t\t</div>\r\n\r\n");
                EndContext();
#line 22 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
         if (Model.Id != 0)
		{

#line default
#line hidden
                BeginContext(709, 33, true);
                WriteLiteral("\t\t\t<div class=\"col-12\">\r\n\t\t\t\t<h2>");
                EndContext();
                BeginContext(743, 18, false);
#line 25 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
               Write(Localizer["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(761, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(763, 14, false);
#line 25 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
                                   Write(Model.ClientId);

#line default
#line hidden
                EndContext();
                BeginContext(777, 18, true);
                WriteLiteral("</h2>\r\n\t\t\t</div>\r\n");
                EndContext();
#line 27 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
		}

#line default
#line hidden
                BeginContext(800, 29, true);
                WriteLiteral("\r\n\t\t<div class=\"col-12\">\r\n\t\t\t");
                EndContext();
                BeginContext(829, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fbbd746ff3784ffaa1df5a3203575f7adeb2c710096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 30 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(889, 23, true);
                WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
                EndContext();
#line 34 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
     if (Model.Id != 0)
	{
		

#line default
#line hidden
                BeginContext(941, 55, false);
#line 36 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
   Write(await Html.PartialAsync("Client/Section/ActionButtons"));

#line default
#line hidden
                EndContext();
#line 36 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
                                                                
	}

#line default
#line hidden
                BeginContext(1002, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1006, 42, false);
#line 39 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
Write(await Html.PartialAsync("Client/Settings"));

#line default
#line hidden
                EndContext();
                BeginContext(1048, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1052, 55, false);
#line 40 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Configuration\Client.cshtml"
Write(await Html.PartialAsync("Client/Section/ActionButtons"));

#line default
#line hidden
                EndContext();
                BeginContext(1107, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1116, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1140, 258, true);
                WriteLiteral(@"
	<script>
		$(function () {
			//Disable enter for this form
			FormMvc.disableEnter($('#client-form'));

			//Radio image
			$(""label.radio-img>img"").click(function () {
				$(this).parent().find(""input:radio"").click();
			});
		});
	</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
