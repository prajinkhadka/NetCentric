#pragma checksum "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab7fbad4e7bc643c6e49f1c677d9a8f26d9ee93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/_ViewImports.cshtml"
using RestaurantManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/_ViewImports.cshtml"
using RestaurantManagement.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab7fbad4e7bc643c6e49f1c677d9a8f26d9ee93", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f0b9ad920a54875148dd65b8d292e2fa694e92", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1>");
#nullable restore
#line 4 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 6 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
 foreach (var pie in Model.Pies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\n        <div class=\"thumbnail\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 188, "\"", 216, 1);
#nullable restore
#line 10 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
WriteAttributeValue("", 194, pie.ImageThumbnailUrl, 194, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 217, "\"", 223, 0);
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"caption\">\n                <h3 class=\"pull-right\">");
#nullable restore
#line 12 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
                                  Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <h3>\n                    <a>");
#nullable restore
#line 14 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
                  Write(pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </h3>\n                <p>");
#nullable restore
#line 16 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
              Write(pie.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 20 "/home/prajin/RiderProjects/RestaurantManagement/RestaurantManagement/Views/Pie/List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591