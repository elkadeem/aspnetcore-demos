#pragma checksum "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f2561b890d6e8c3a2a4014d740a6334bb9dd15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Edit), @"mvc.1.0.view", @"/Views/Customers/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f2561b890d6e8c3a2a4014d740a6334bb9dd15", @"/Views/Customers/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c9bc98e5ba8773c83746908ba9b7a9baed247a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirtMVC.App.Entities.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>Customer</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f2561b890d6e8c3a2a4014d740a6334bb9dd154351", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("            ");
#nullable restore
#line 15 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
       Write(Html.Partial("_CustomerData"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f2561b890d6e8c3a2a4014d740a6334bb9dd156280", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\r\n    jQuery(document).ready(function () {\r\n\r\n    getCities($(\'#");
#nullable restore
#line 32 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
             Write(Html.IdFor(model => model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\').val());\r\n\r\n    $(\'#");
#nullable restore
#line 34 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
   Write(Html.IdFor(model => model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\').change(function () {\r\n    var countryId = $(this).val();\r\n    getCities(countryId);\r\n    });\r\n\r\n    });\r\n\r\n        function getCities(countryId) {\r\n            if (!countryId || countryId === 0)\r\n                return;\r\n\r\n    $.getJSON(\'");
#nullable restore
#line 45 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
          Write(Url.Action("Cities", "Customers"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?countryId=\' + countryId)\r\n    .done(function (data) {\r\n\r\n    $(\'#");
#nullable restore
#line 48 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
   Write(Html.IdFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral(" option\').remove();\r\n\r\n    $.each(data, function (index, item) {\r\n    var option = $(\'<option>\').val(item.id).text(item.name);\r\n        $(\'#");
#nullable restore
#line 52 "C:\Users\welkadim\source\repos\MOE31Demos\MVC\FirtMVC.App\Views\Customers\Edit.cshtml"
       Write(Html.IdFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\').append(option);\r\n        });\r\n\r\n\r\n        });\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirtMVC.App.Entities.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
