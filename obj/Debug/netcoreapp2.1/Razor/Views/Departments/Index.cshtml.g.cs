#pragma checksum "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02625250f235d7225f77a12c10f00b56e26a36c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Index), @"mvc.1.0.view", @"/Views/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Index.cshtml", typeof(AspNetCore.Views_Departments_Index))]
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
#line 1 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02625250f235d7225f77a12c10f00b56e26a36c2", @"/Views/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e82a99d0f68a83eb80a8c42eea95417221ff4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
  
    ViewData["Title"] = "Departments";

#line default
#line hidden
            BeginContext(94, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 6 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 15, true);
            WriteLiteral("</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(132, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227f10710a244a808345b24113413aac", async() => {
                BeginContext(155, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(169, 87, true);
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(257, 38, false);
#line 16 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(295, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(348, 40, false);
#line 19 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(388, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 24 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(477, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(524, 37, false);
#line 28 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(561, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(614, 39, false);
#line 31 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(653, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(706, 40, false);
#line 34 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(746, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(764, 46, false);
#line 35 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(810, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(828, 44, false);
#line 36 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(872, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 39 "/Users/brunooliveira/ProjectsAsp/SalesWebMvc/Views/Departments/Index.cshtml"
}

#line default
#line hidden
            BeginContext(907, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
