#pragma checksum "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b80816dd7feaa2f3b11538568a056176e46a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Name), @"mvc.1.0.view", @"/Views/Home/Name.cshtml")]
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
#line 1 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name.cshtml"
using FirtMVC.App.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b80816dd7feaa2f3b11538568a056176e46a3c", @"/Views/Home/Name.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c9bc98e5ba8773c83746908ba9b7a9baed247a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Name : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <div>Id: ");
#nullable restore
#line 4 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name.cshtml"
        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Name: ");
#nullable restore
#line 5 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Home\Name.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
