#pragma checksum "C:\Users\107019\source\repos\Car_Asp.netcoreEmpty\Asp.netcoreEmpty\Views\Home\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9b38cba08bdd6e388d7188ca918b74732c13419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorPage), @"mvc.1.0.view", @"/Views/Home/ErrorPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9b38cba08bdd6e388d7188ca918b74732c13419", @"/Views/Home/ErrorPage.cshtml")]
    public class Views_Home_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nViewBag.Title = \"404 Error\";\r\n\r\n    <div class=\"alert alert-danger mt-1 mb-1\">\r\n        <h4>404 Not Found Error: </h4>\r\n\r\n        <hr /> \r\n        <h5>\r\n\r\n            Employee with Id = ");
#nullable restore
#line 16 "C:\Users\107019\source\repos\Car_Asp.netcoreEmpty\Asp.netcoreEmpty\Views\Home\ErrorPage.cshtml"
                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cannot be found\r\n\r\n        </h5>\r\n\r\n    </div>\r\n\r\n         <a asp-action=\"Details\" asp-controller=\"home\" class=\"btn btn-outline-success\">\r\n                    Click here to see the list of all employees\r\n\r\n         </a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591