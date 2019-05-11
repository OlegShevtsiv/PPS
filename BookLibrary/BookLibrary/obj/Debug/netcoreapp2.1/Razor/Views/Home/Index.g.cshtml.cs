#pragma checksum "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b519a9258631358629e11d9a1ee6439501aebef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess.Models;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess;

#line default
#line hidden
#line 1 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
using Services.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b519a9258631358629e11d9a1ee6439501aebef1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a812df736c114cf8d16a5076685ff0ecc13143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.DTO.BookDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex flex-nowrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAuthorInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBookInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(201, 95, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 mt-5\">\r\n            ");
            EndContext();
            BeginContext(296, 452, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b08ad457cf44eb8a0ff6beb22899503", async() => {
                BeginContext(361, 380, true);
                WriteLiteral(@"
                <div class=""form-group col-6 col-md-9 d-flex flex-nowrap pl-md-0"">
                    <input type=""text"" class=""form-control border-primary w-100 h1 my-0 form-control-lg"" id=""bookSearch"" placeholder=""Search book"">
                </div>
                <button type=""submit"" class=""btn btn-primary btn-lg col-6 col-md-3 pr-md-0"">Search</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(748, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(935, 195, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h1 class=\"mt-3 mb-4\">All Releases</h1>\r\n            </div>\r\n");
            EndContext();
#line 28 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
            BeginContext(1187, 96, true);
            WriteLiteral("                <div class=\"col-12 col-md-6 col-lg-3\">\r\n                    <div class=\"card\">\r\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                         if (book.Image != null)
                        {

#line default
#line hidden
            BeginContext(1360, 92, true);
            WriteLiteral("                            <img class=\"card-img-top\" @*style=\"width:120px; height:150px;\"*@");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1452, "\"", 1518, 2);
            WriteAttributeValue("", 1458, "data:image/jpeg;base64,", 1458, 23, true);
#line 34 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 1481, Convert.ToBase64String(book.Image), 1481, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1519, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 35 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1551, 116, true);
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <span class=\"card-title h3 d-block mt-1 mb-2\">\"");
            EndContext();
            BeginContext(1668, 10, false);
#line 37 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                  Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 118, true);
            WriteLiteral("\"</span>\r\n                        \r\n                            <span class=\"card-title h4 d-block mt-1 mb-2\">Author: ");
            EndContext();
            BeginContext(1796, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdafcfbe4d74ca9aac1df9f3fdd2888", async() => {
                BeginContext(1879, 37, false);
#line 39 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                                                                                                               Write(authorService.Get(book.AuthorId).Name);

#line default
#line hidden
                EndContext();
                BeginContext(1916, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1918, 40, false);
#line 39 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                                                                                                                                                      Write(authorService.Get(book.AuthorId).Surname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                                                                  WriteLiteral(authorService.Get(book.AuthorId).Id);

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
            BeginContext(1962, 159, true);
            WriteLiteral("</span>\r\n                        \r\n                            <hr />\r\n                            <span class=\"card-title h4 d-block mt-1 mb-2\">Release year: ");
            EndContext();
            BeginContext(2122, 9, false);
#line 42 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                                   Write(book.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2131, 91, true);
            WriteLiteral("</span>\r\n                            <span class=\"card-title h4 d-block mt-1 mb-2\">Rating: ");
            EndContext();
            BeginContext(2223, 9, false);
#line 43 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                                             Write(book.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(2232, 41, true);
            WriteLiteral(" / 5</span>\r\n                            ");
            EndContext();
            BeginContext(2273, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbcbab9e7594ad499427cb7931bfe94", async() => {
                BeginContext(2361, 4, true);
                WriteLiteral("More");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
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
            BeginContext(2369, 84, true);
            WriteLiteral("\r\n                    </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 49 "C:\Users\User\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2468, 22, true);
            WriteLiteral("        </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorService authorService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.DTO.BookDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
