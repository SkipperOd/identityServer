#pragma checksum "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d61295022f91f968874664a5cff4a88f691fda65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Common_ErrorPage), @"mvc.1.0.view", @"/Views/Shared/Common/ErrorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Common/ErrorPage.cshtml", typeof(AspNetCore.Views_Shared_Common_ErrorPage))]
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
#line 1 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
using AuthServer.Admin.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d61295022f91f968874664a5cff4a88f691fda65", @"/Views/Shared/Common/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f437c16c7d8a97b192ba089edebd2caf59fa6f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Common_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
  
	ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(175, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(202, 22, false);
#line 9 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
                   Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(224, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 11 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
 if (ViewBag.Notifications != null)
{
	var settings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.All
	};

	var obj = JsonConvert.DeserializeObject<List<NotificationHelpers.Alert>>(ViewBag.Notifications, settings);

	foreach (NotificationHelpers.Alert notification in obj)
	{

#line default
#line hidden
            BeginContext(544, 26, true);
            WriteLiteral("\t\t<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(571, 20, false);
#line 22 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
                           Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(591, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 23 "D:\Test\AuthServer\src\AuthServer.Admin\Views\Shared\Common\ErrorPage.cshtml"
	}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
