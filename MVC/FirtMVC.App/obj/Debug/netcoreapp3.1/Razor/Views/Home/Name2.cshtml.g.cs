#pragma checksum "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8faa4d72b2594bd4c0bd7ced8ff7dd600e8a0a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Name2), @"mvc.1.0.view", @"/Views/Home/Name2.cshtml")]
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
#nullable restore
#line 1 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
using FirtMVC.App.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8faa4d72b2594bd4c0bd7ced8ff7dd600e8a0a67", @"/Views/Home/Name2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c9bc98e5ba8773c83746908ba9b7a9baed247a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Name2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
  
    DateTime GetDateTime(int days)
    {
        return DateTime.Now.AddDays(days);
    }

    var customer = (Customer)ViewBag.Customer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1>View Bage</h1>\r\n    <div>\r\n        ");
#nullable restore
#line 15 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
   Write(ViewBag.CurrentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        ");
#nullable restore
#line 16 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
   Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    <h1>View Date</h1>\r\n    <div>\r\n        ");
#nullable restore
#line 22 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
   Write(ViewData["CurrentDate2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        ");
#nullable restore
#line 23 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
    Write(((Customer)ViewData["Customer2"]).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    Current Date: ");
#nullable restore
#line 27 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
             Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>Date after 10 days: ");
#nullable restore
#line 28 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
                      Write(GetDateTime(10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div>\r\n");
#nullable restore
#line 30 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
         if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"color:red\">Hiiiiiii</div>\r\n");
#nullable restore
#line 33 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"color:green\">Hiiiiiii</div>\r\n");
#nullable restore
#line 37 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n        <ul>\r\n");
#nullable restore
#line 41 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
             for (int i = 0; i <= 10; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    email");
#nullable restore
#line 44 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
                     Write(i ==0? "20": i.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("@hotmail.com\r\n                </li>\r\n");
#nullable restore
#line 46 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div>");
            WriteLiteral("</div>\r\n</div>");
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
