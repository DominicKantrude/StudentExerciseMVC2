#pragma checksum "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d76deb215fce537aa65e59fbadf61ac372f5e309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\_ViewImports.cshtml"
using StudentExerciseMVC2;

#line default
#line hidden
#line 2 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\_ViewImports.cshtml"
using StudentExerciseMVC2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d76deb215fce537aa65e59fbadf61ac372f5e309", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2cefb9cd0c1cb786a05a5f4ab11c2427263dad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentExercisesMVC2.Models.Student>>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d76deb215fce537aa65e59fbadf61ac372f5e3093890", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 148, false);
#line 16 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
           Write(Html.ActionLink(@Html.DisplayNameFor(model => model.FirstName), "Index", new { _orderBy = "FirstName", _sortDirection = ViewData["sortDirection"] }));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 146, false);
#line 19 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
           Write(Html.ActionLink(@Html.DisplayNameFor(model => model.LastName), "Index", new { _orderBy = "LastName", _sortDirection = ViewData["sortDirection"] }));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(665, 152, false);
#line 22 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
           Write(Html.ActionLink(@Html.DisplayNameFor(model => model.SlackHandle), "Index", new { _orderBy = "SlackHandle", _sortDirection = ViewData["sortDirection"] }));

#line default
#line hidden
            EndContext();
            BeginContext(817, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(873, 149, false);
#line 25 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
           Write(Html.ActionLink(@Html.DisplayNameFor(model => model.Cohort.Name), "Index", new { _orderBy = "CohortId", _sortDirection = ViewData["sortDirection"] }));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1157, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1218, 44, false);
#line 35 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1330, 43, false);
#line 38 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1441, 46, false);
#line 41 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1555, 46, false);
#line 44 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cohort.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1669, 53, false);
#line 47 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1747, 59, false);
#line 48 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1831, 64, false);
#line 49 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Delete", "DeleteConfirm", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\domin\workspace\StudentExerciseMVC2\StudentExerciseMVC2\Views\Student\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1950, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentExercisesMVC2.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591