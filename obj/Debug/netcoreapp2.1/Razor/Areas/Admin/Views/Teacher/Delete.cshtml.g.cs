#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed449db000cf595a774df638c83ef3de863d8ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teacher_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Teacher/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Teacher_Delete))]
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
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed449db000cf595a774df638c83ef3de863d8ed", @"/Areas/Admin/Views/Teacher/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(58, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(83, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4f7c088c5a4415b816be6fb84921be6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 93, "~/img/teacher/", 93, 14, true);
#line 7 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
AddHtmlAttributeValue("", 107, Model.Image, 107, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(148, 137, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-2\">\r\n        <h6>FullName</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(286, 14, false);
#line 15 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(300, 155, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Position</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(456, 14, false);
#line 25 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(470, 151, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Facebook</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(622, 14, false);
#line 33 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.Facebook);

#line default
#line hidden
            EndContext();
            BeginContext(636, 150, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Twitter</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(787, 13, false);
#line 41 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.Twitter);

#line default
#line hidden
            EndContext();
            BeginContext(800, 147, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n        <h6>Pinterest</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(948, 15, false);
#line 49 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.Pinterest);

#line default
#line hidden
            EndContext();
            BeginContext(963, 151, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>VContact</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1115, 14, false);
#line 57 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.VContact);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 151, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Category</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1281, 19, false);
#line 65 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Teacher\Delete.cshtml"
       Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 56, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row mt-3\">\r\n    ");
            EndContext();
            BeginContext(1356, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf34dc9abd84aa6a29dff5e269e7367", async() => {
                BeginContext(1404, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1415, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1421, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9a7d98e2a874d79a7d7a310f21d4181", async() => {
                BeginContext(1442, 78, true);
                WriteLiteral("\r\n        <input type=\"submit\" class=\"btn btn-danger\"  value=\"Delete\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1527, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
