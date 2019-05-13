#pragma checksum "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8833ad7801d17fc051e4db2236d8830751d69d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAuthorInfo), @"mvc.1.0.view", @"/Views/Home/GetAuthorInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetAuthorInfo.cshtml", typeof(AspNetCore.Views_Home_GetAuthorInfo))]
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
#line 1 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#line 1 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
using Services.Interfaces;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
using Services.Filters;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
using BookLibrary.ViewModels.ManageComments;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8833ad7801d17fc051e4db2236d8830751d69d", @"/Views/Home/GetAuthorInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAuthorInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTO.AuthorDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBookInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
  
    ViewData["Title"] = "Get author info";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(269, 180, true);
            WriteLiteral("\r\n<div class=\"container pt-3 pb-4\">\r\n    <div class=\"row py-5\">\r\n        <div class=\"col-12 col-md-5 col-lg-4 d-flex flex-column pt-3\">\r\n            <img class=\"card-img-top w-100\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 449, "\"", 481, 2);
#line 16 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
WriteAttributeValue("", 455, Model.Name, 455, 11, false);

#line default
#line hidden
#line 16 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
WriteAttributeValue(" ", 466, Model.Surname, 467, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 35, true);
            WriteLiteral(" style=\"width:240px; height:300px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 517, "\"", 585, 2);
            WriteAttributeValue("", 523, "data:image/jpeg;base64,", 523, 23, true);
#line 16 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
WriteAttributeValue("", 546, Convert.ToBase64String(@Model.Image), 546, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(586, 188, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-12 col-md-7 col-lg-8 d-flex flex-column pt-3\">\r\n            <div class=\"h4\">Author full name</div>\r\n            <div class=\"h5 text-secondary\">");
            EndContext();
            BeginContext(775, 10, false);
#line 20 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(785, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(787, 13, false);
#line 20 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                                  Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(800, 111, true);
            WriteLiteral("</div>\r\n            <div class=\"h4\">Description</div>\r\n            <p class=\"text-secondary\">\r\n                ");
            EndContext();
            BeginContext(912, 17, false);
#line 23 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(929, 193, true);
            WriteLiteral("\r\n            </p>\r\n\r\n\r\n            <div class=\"more_books d-flex flex-wrap\">\r\n                <div class=\"col-12 text-center\">\r\n                    <h4>All books</h4>\r\n                </div>\r\n");
            EndContext();
#line 31 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                 foreach (var book in bookService.Get(new BookFilterByAuthor { AuthorId = Model.Id }))
                {

#line default
#line hidden
            BeginContext(1245, 106, true);
            WriteLiteral("                    <div class=\"col-6 col-md-3\">\r\n                        <div class=\"card text-center\">\r\n");
            EndContext();
#line 35 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                             if (book.Image != null)
                            {

#line default
#line hidden
            BeginContext(1436, 59, true);
            WriteLiteral("                                <img class=\"card-img w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1495, "\"", 1561, 2);
            WriteAttributeValue("", 1501, "data:image/jpeg;base64,", 1501, 23, true);
#line 37 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
WriteAttributeValue("", 1524, Convert.ToBase64String(book.Image), 1524, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1562, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 38 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                            }

#line default
#line hidden
            BeginContext(1598, 108, true);
            WriteLiteral("                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1707, 10, false);
#line 40 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                                  Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 71, true);
            WriteLiteral("</h5>\r\n                                <h6 class=\"card-title\">Release: ");
            EndContext();
            BeginContext(1789, 9, false);
#line 41 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                                           Write(book.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1798, 68, true);
            WriteLiteral("</h6>\r\n                                <h6 class=\"card-title\">Rate: ");
            EndContext();
            BeginContext(1867, 9, false);
#line 42 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                                        Write(book.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 39, true);
            WriteLiteral("</h6>\r\n                                ");
            EndContext();
            BeginContext(1915, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b88cf56d5714fa6b7fa6d86e6211afc", async() => {
                BeginContext(1998, 4, true);
                WriteLiteral("More");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                                                                                             WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2006, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 47 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(2123, 68, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-12\">\r\n\r\n");
            EndContext();
#line 52 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
              await Html.RenderPartialAsync("~/Views/ManageComments/_CommentPartial.cshtml", new CommentedEssenceViewModel { EssenceId = Model.Id, isBook = false });

#line default
#line hidden
            BeginContext(2359, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IBookService bookService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTO.AuthorDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
