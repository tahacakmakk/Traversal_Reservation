#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_GuideDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac2cfb4442451f3551ac829ec2ed6b7ed800cb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GuideDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GuideDetail/Default.cshtml")]
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
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac2cfb4442451f3551ac829ec2ed6b7ed800cb5", @"/Views/Shared/Components/_GuideDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GuideDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Guide>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"author-card mt-5\">\r\n    <div class=\"row align-items-center\">\r\n        <div class=\"col-sm-3 col-6\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 188, "\"", 206, 1);
#nullable restore
#line 7 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_GuideDetail\Default.cshtml"
WriteAttributeValue("", 194, Model.Image, 194, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"rounded-circle img-fluid\">\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n            <h3 class=\"mb-3 title\">");
#nullable restore
#line 11 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_GuideDetail\Default.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n            <p> \r\n                ");
#nullable restore
#line 13 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_GuideDetail\Default.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <ul class=""author-icons mt-4"">
                <li>
                    <a class=""facebook"" href=""#url"">
                        <span class=""fa fa-facebook""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""twitter"" href=""#url"">
                        <span class=""fa fa-twitter""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""google"" href=""#url"">
                        <span class=""fa fa-google-plus""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""linkedin"" href=""#url"">
                        <span class=""fa fa-linkedin""
                              aria-hidden=""true""></span>
                    </a>
                </li>
             ");
            WriteLiteral(@"   <li>
                    <a class=""github"" href=""#url"">
                        <span class=""fa fa-github""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""dribbble"" href=""#url"">
                        <span class=""fa fa-dribbble""
                              aria-hidden=""true""></span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Guide> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
