#pragma checksum "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc6c84c5feb90fc31d3ea98eddb7002b44264f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc6c84c5feb90fc31d3ea98eddb7002b44264f7", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43487e7d498466fecd4ad07e10654633fe305c4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var Departement = ViewData["Departement"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <dl class=row>\r\n        <dt class=\"col-3\">");
#nullable restore
#line 13 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayNameFor(e => e.Name ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-3\">");
#nullable restore
#line 14 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayFor(e => e.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-3\">");
#nullable restore
#line 15 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayNameFor(e => e.Address ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-3\">");
#nullable restore
#line 16 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayFor(e => e.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-3\">");
#nullable restore
#line 17 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayNameFor(e => e.Salary ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-3\">");
#nullable restore
#line 18 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Html.DisplayFor(e => e.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-3\">Department</dt>\r\n        <dd class=\"col-3\">");
#nullable restore
#line 20 "D:\Omar\Courses\Web\ASP.Net Backend\Practice\sessions\ASP.NET Core MVC\day 03 - 04\Demo.PL\Views\Employee\Details.cshtml"
                     Write(Departement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc6c84c5feb90fc31d3ea98eddb7002b44264f76555", async() => {
                WriteLiteral("Back To List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
