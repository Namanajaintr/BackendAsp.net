#pragma checksum "C:\Users\107019\source\repos\Car_Asp.netcoreEmpty\Asp.netcoreEmpty\Views\Error\500.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9574059611641dc9302a78e35898ef4bdde1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_500), @"mvc.1.0.view", @"/Views/Error/500.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9574059611641dc9302a78e35898ef4bdde1d3", @"/Views/Error/500.cshtml")]
    public class Views_Error_500 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\107019\source\repos\Car_Asp.netcoreEmpty\Asp.netcoreEmpty\Views\Error\500.cshtml"
  
    
        ViewBag.Title = "(500) An Error Occurred";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>(500) An Error Occurred.</h1>\r\n    <p>Something went wrong.</p>\r\n    <p>Please, contact the support by emailing them this page error.</p>\r\n    <p>To find the available contacts go to: ");
#nullable restore
#line 11 "C:\Users\107019\source\repos\Car_Asp.netcoreEmpty\Asp.netcoreEmpty\Views\Error\500.cshtml"
                                        Write(Html.ActionLink("Contacts", "500", "Error"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
