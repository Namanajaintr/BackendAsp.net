#pragma checksum "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ba7838e31ed81ccc87a2162cf5fd2562bb191f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ba7838e31ed81ccc87a2162cf5fd2562bb191f", @"/Views/Home/Index1.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cart_aspnetcore_empty.Modal.Cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <table>
            <tr>
                <th> Product_ID</th>
                <th> Product_Name</th>
                <th> Product_Price</th>
                <th> Product_Qty</th>
                <th> Payment_Mode</th>
                <th> Product_Type</th>
            </tr>
");
#nullable restore
#line 13 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
            foreach (var cart in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
               Write(cart.Product_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
               Write(cart.Product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 17 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
                Write(cart.Product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 18 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
                Write(cart.Product_Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 19 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
                Write(cart.Payment_Mode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 20 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
                Write(cart.Product_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\107019\source\repos\Cart_aspnetcore_empty\Cart_aspnetcore_empty\Views\Home\Index1.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cart_aspnetcore_empty.Modal.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591