#pragma checksum "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e67ec25ec2a10c6fbbcf853b7432a681d7102f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AddComment), @"mvc.1.0.view", @"/Views/Comment/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e67ec25ec2a10c6fbbcf853b7432a681d7102f7", @"/Views/Comment/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"leave-comment-form mt-5\" id=\"reply\">\r\n    <h4 class=\"side-title mb-2\">Bir yorum bırakın.</h4>\r\n    <p class=\"mb-4\">\r\n        İşaretli alanları doldurmanı gerekmektedir *\r\n    </p>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e67ec25ec2a10c6fbbcf853b7432a681d7102f74974", async() => {
                WriteLiteral("\r\n      \r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 356, "\"", 379, 1);
#nullable restore
#line 12 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml"
WriteAttributeValue("", 364, ViewBag.destID, 364, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DestinationID\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 434, "\"", 457, 1);
#nullable restore
#line 13 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml"
WriteAttributeValue("", 442, ViewBag.userID, 442, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AppUserID\" />\r\n        <div class=\"form-group\">\r\n            <textarea name=\"CommentContent\" class=\"form-control\" placeholder=\"Yorumunuz *\"");
                BeginWriteAttribute("required", " required=\"", 604, "\"", 615, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                      spellcheck=\"false\"></textarea>\r\n        </div>\r\n\r\n        <div class=\"submit text-right\">\r\n            <button class=\"btn btn-style btn-primary\">Yorum Yap </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3> Yorum yapabilmek için üye olmanız gerekmektedir.</h3>\r\n");
#nullable restore
#line 28 "C:\Users\taha8\Desktop\Travel Trip Project\TraversalCoreProje\TraversalCoreProje\Views\Comment\AddComment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src =\"https://code.jquery.com/jquery-3.5.1.mi.js\" type=\"text/javascript\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
