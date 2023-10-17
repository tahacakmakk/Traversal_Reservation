#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95b78eb2f7f3afe406702181fce2013aacd19191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b78eb2f7f3afe406702181fce2013aacd19191", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Member/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""main-content position-relative bg-gray-100 max-height-vh-100 h-100"">

	<div class=""container-fluid"">
		<div class=""page-header min-height-150 border-radius-xl mt-4"" style=""background-image: url('/soft-ui-dashboard/assets/img/bg-006.jpg'); background-position-y: 35%; "">
		</div>
		<div class=""card card-body blur shadow-blur mx-4 mt-n6 overflow-hidden"">
			<div class=""row gx-4"">
				<div class=""col-auto my-auto"">
					<div class=""h-100"">
						<h2 class=""mb-0 font-weight-bold "">
							Rotalar
						</h2>
					</div>
				</div>
			</div>
		</div>
</div>
<div class=""row mt-5"">
	<div class=""col-12"">
		<div class=""card mb-4"">
		
			<div class=""card-body px-0 pt-0 pb-2 pt-5"">
				<div class=""table-responsive p-0"">
					<table class=""table align-items-center mb-0"">

						<tr>
							<td>#</td>
							<td>Şehir</td>
							<td>Süre</td>
							<td>Kapasite</td>
							<td>Fiyat</td>
							<td>Detaylar</td>
						</tr>
");
#nullable restore
#line 43 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                         foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                               Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 47 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 48 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                               Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 49 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                               Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 50 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n\t\t\t\t\t\t\t\t<td><a href=\"#\" class=\"btn \" style=\"margin:10px 0px 10px 0px\">Detaylar</a></td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 53 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</table>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
