#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c44173004682d7b786f06072adf3d43c78e55783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingHotelSearch_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
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
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44173004682d7b786f06072adf3d43c78e55783", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04823ba6dec60ea6861dd2404204dbb515accc6c", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BookingHotelSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingHotelSearchViewModel.Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <h4 class=""card-header"">Booking Otel Rezarvasyon Sayfası</h4>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Otel Adı</th>
                    <th>Otel Puanı</th>
                    <th>Otel Değerlendirmesi</th>
                    <th>Detaylar</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 23 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                 foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 27 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(item.reviewScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(item.reviewScoreWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingHotelSearchViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
