#pragma checksum "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0d8908bf59a18b6079317ce587c84d8cf49a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicine_Index), @"mvc.1.0.view", @"/Views/Medicine/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Medicine/Index.cshtml", typeof(AspNetCore.Views_Medicine_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0d8908bf59a18b6079317ce587c84d8cf49a4d", @"/Views/Medicine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8ea490bea9bf6cc189a7368c6b4f0c2990b8945", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMedicineShopping.BusinessLayer.ViewModels.MedicineViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(119, 51, true);
            WriteLiteral("<div class=\"text-right\" style=\"margin-top:10px;\">\r\n");
            EndContext();
            BeginContext(171, 105, false);
#line 6 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
Write(Html.ActionLink("Doctor Appointment", "DoctorAppointment", "Medicine", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(276, 193, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\" style=\"margin-top:10px;\">\r\n    <h4>Search Medicines And Product</h4>\r\n</div>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(470, 32, false);
#line 14 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(502, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(526, 33, false);
#line 15 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(559, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(583, 33, false);
#line 16 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(616, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(640, 33, false);
#line 17 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(673, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(697, 36, false);
#line 18 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Features));

#line default
#line hidden
            EndContext();
            BeginContext(733, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(757, 36, false);
#line 19 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(793, 78, true);
            WriteLiteral("</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
         if (Model.PageCount() == 0)
        {

#line default
#line hidden
            BeginContext(920, 133, true);
            WriteLiteral("            <tr>\r\n                <td style=\"color:red;\" colspan=\"12\">\r\n                    Records not found |\r\n                    ");
            EndContext();
            BeginContext(1054, 86, false);
#line 29 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(Html.ActionLink("Go To Home", "Index", "Medicine", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 35 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
             foreach (var product in Model.PaginatedInterview())
            {

#line default
#line hidden
            BeginContext(1301, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1340, 12, false);
#line 38 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1380, 13, false);
#line 39 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1421, 87, false);
#line 40 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Price.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN")));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1536, 13, false);
#line 41 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1577, 16, false);
#line 42 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Features);

#line default
#line hidden
            EndContext();
            BeginContext(1593, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1621, 16, false);
#line 43 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(product.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1687, 118, false);
#line 45 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", "Medicine", new { MedicineId = product.MedicineId, @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1830, 118, false);
#line 46 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
               Write(Html.ActionLink("Buy Now", "Details", "Medicine", new { MedicineId = product.MedicineId, @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 49 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
            }

#line default
#line hidden
#line 49 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2018, 49, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<ul class=\"pagination\">\r\n");
            EndContext();
#line 54 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
     for (int i = 1; i <= Model.PageCount(); i++)
    {

#line default
#line hidden
            BeginContext(2125, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2136, "\"", 2204, 1);
#line 56 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
WriteAttributeValue("", 2144, i == Model.CurrentPage ? "page-item active" : "page-item", 2144, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2205, 35, true);
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2240, "\"", 2285, 1);
#line 57 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
WriteAttributeValue("", 2247, Url.Action("Index", new { page = i }), 2247, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2286, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2288, 1, false);
#line 57 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2289, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 59 "D:\IIHT DATA\IIHT\Task-10\InMemory\Medicine\OnlineMedicineShopping\Views\Medicine\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2317, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMedicineShopping.BusinessLayer.ViewModels.MedicineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
