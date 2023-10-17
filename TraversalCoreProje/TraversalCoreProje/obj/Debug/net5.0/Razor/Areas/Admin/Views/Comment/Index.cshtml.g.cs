#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e5fafb3bf7d7a9bcd53df267c2b9eb6b945375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e5fafb3bf7d7a9bcd53df267c2b9eb6b945375", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04823ba6dec60ea6861dd2404204dbb515accc6c", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Basic Bootstrap Table -->
<div class=""card"">
    <h5 class=""card-header"">Yorum Listesi</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Kullanıcı</th>
                    <th>Rota</th>
                    <th>Tarih</th>
                    <th>Sil</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 25 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
                 foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
                        Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1117, 2);
            WriteAttributeValue("", 1073, "/Admin/Comment/DeleteComment/", 1073, 29, true);
#nullable restore
#line 33 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1102, item.CommentID, 1102, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\"><i class=\"bx bx-x\"></i> Sil</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591