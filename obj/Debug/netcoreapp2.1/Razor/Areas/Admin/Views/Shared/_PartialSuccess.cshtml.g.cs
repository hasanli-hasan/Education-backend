#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Shared\_PartialSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb950d6ade30968f58557c8a0f43ccedf382b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__PartialSuccess), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_PartialSuccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_PartialSuccess.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__PartialSuccess))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb950d6ade30968f58557c8a0f43ccedf382b39", @"/Areas/Admin/Views/Shared/_PartialSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__PartialSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Shared\_PartialSuccess.cshtml"
 if (TempData["success"] != null)
{

#line default
#line hidden
            BeginContext(38, 50, true);
            WriteLiteral("    <div id=\"success\" class=\"alert alert-success\">");
            EndContext();
            BeginContext(89, 19, false);
#line 3 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Shared\_PartialSuccess.cshtml"
                                             Write(TempData["success"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 4 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Shared\_PartialSuccess.cshtml"
}

#line default
#line hidden
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
