#pragma checksum "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\ViewDataSample\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4991b0ad1ba077e6509380c4c1436374014860"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewDataSample_Index), @"mvc.1.0.view", @"/Views/ViewDataSample/Index.cshtml")]
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
#line 1 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\_ViewImports.cshtml"
using FirtMVC.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\_ViewImports.cshtml"
using FirtMVC.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4991b0ad1ba077e6509380c4c1436374014860", @"/Views/ViewDataSample/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c9bc98e5ba8773c83746908ba9b7a9baed247a", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewDataSample_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1>\r\n        View Bage\r\n    </h1>\r\n    ");
#nullable restore
#line 5 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\ViewDataSample\Index.cshtml"
Write(ViewBag.CurrentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 7 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\ViewDataSample\Index.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <h1>\r\n        Temp Data\r\n    </h1>\r\n    ");
#nullable restore
#line 14 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\ViewDataSample\Index.cshtml"
Write(TempData["CurrentDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 16 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\ViewDataSample\Index.cshtml"
Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
