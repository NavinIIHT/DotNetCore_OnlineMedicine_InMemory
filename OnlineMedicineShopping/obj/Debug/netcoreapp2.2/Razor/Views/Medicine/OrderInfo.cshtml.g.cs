#pragma checksum "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c3026a58066acd35c86f17308d183b8290ee836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicine_OrderInfo), @"mvc.1.0.view", @"/Views/Medicine/OrderInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Medicine/OrderInfo.cshtml", typeof(AspNetCore.Views_Medicine_OrderInfo))]
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
#line 1 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\_ViewImports.cshtml"
using OnlineMedicineShopping;

#line default
#line hidden
#line 2 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\_ViewImports.cshtml"
using OnlineMedicineShopping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3026a58066acd35c86f17308d183b8290ee836", @"/Views/Medicine/OrderInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8ea490bea9bf6cc189a7368c6b4f0c2990b8945", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicine_OrderInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMedicineShopping.Entities.MedicineOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
  
    ViewData["Title"] = "OrderInfo";

#line default
#line hidden
            BeginContext(112, 231, true);
            WriteLiteral("<div class=\"container text-center\" style=\"margin-top:10px\">\r\n    <div class=\"jumbotron mt-3\">\r\n        <h1>Purchase Order Info</h1>\r\n        <p class=\"lead\">Thanku for shopping with us your order will be processed....</p>\r\n        ");
            EndContext();
            BeginContext(344, 86, false);
#line 9 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
   Write(Html.ActionLink("Shop Again", "Index", "Medicine", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(430, 103, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(534, 35, false);
#line 15 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
           Write(Html.DisplayNameFor(m => m.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(569, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(593, 38, false);
#line 16 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
           Write(Html.DisplayNameFor(m => m.MedicineId));

#line default
#line hidden
            EndContext();
            BeginContext(631, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(655, 34, false);
#line 17 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
           Write(Html.DisplayNameFor(m => m.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(689, 78, true);
            WriteLiteral("</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
            BeginContext(817, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(856, 13, false);
#line 25 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
               Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(869, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(897, 16, false);
#line 26 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
               Write(order.MedicineId);

#line default
#line hidden
            EndContext();
            BeginContext(913, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(941, 12, false);
#line 27 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
               Write(order.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(953, 68, true);
            WriteLiteral("</td>\r\n                <td>Product Details</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\OrderInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(1032, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMedicineShopping.Entities.MedicineOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
