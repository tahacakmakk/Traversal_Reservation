#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bae3779bce6196deb134a52e63a8e92897685a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reservation_ApprovalReservation), @"mvc.1.0.view", @"/Areas/Admin/Views/Reservation/ApprovalReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bae3779bce6196deb134a52e63a8e92897685a2", @"/Areas/Admin/Views/Reservation/ApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04823ba6dec60ea6861dd2404204dbb515accc6c", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Reservation_ApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
  
    ViewData["Title"] = "ApprovalReservation";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Basic Bootstrap Table -->
<div class=""card"">
    <h5 class=""card-header font-weight-bold "">Onay Bekleyen Rezervasyonlar</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Kullanıcı Adı</th>
                    <th>Rota</th>
                    <th>Kişi Sayısı</th>
                    <th>Rezervasyon Tarihi</th>
                    <th>Açıklama</th>
                    <th>Onayla</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 25 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                 foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                       Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                       Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                        Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1351, 2);
            WriteAttributeValue("", 1303, "/Admin/Reservation/ToApprove/", 1303, 29, true);
#nullable restore
#line 35 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
WriteAttributeValue("", 1332, item.ReservationID, 1332, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\"><i class=\"bx bx-double-check\"></i> Onayla</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Reservation\ApprovalReservation.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591