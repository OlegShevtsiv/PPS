#pragma checksum "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0550281d26cc659216d2c19f69e6f88ef6d043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetBookInfo), @"mvc.1.0.view", @"/Views/Home/GetBookInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetBookInfo.cshtml", typeof(AspNetCore.Views_Home_GetBookInfo))]
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
#line 1 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#line 2 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#line 3 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess.Models;

#line default
#line hidden
#line 4 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess;

#line default
#line hidden
#line 1 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
using Services.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0550281d26cc659216d2c19f69e6f88ef6d043", @"/Views/Home/GetBookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a812df736c114cf8d16a5076685ff0ecc13143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetBookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTO.BookDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAuthorInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("number"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RateBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
  
    ViewData["Title"] = "Get book info";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(235, 180, true);
            WriteLiteral("\r\n<div class=\"container pt-3 pb-4\">\r\n    <div class=\"row py-5\">\r\n        <div class=\"col-12 col-md-5 col-lg-4 d-flex flex-column pt-3\">\r\n            <img class=\"card-img-top w-100\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 415, "\"", 433, 1);
#line 15 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
WriteAttributeValue("", 421, Model.Title, 421, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 35, true);
            WriteLiteral(" style=\"width:240px; height:300px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 469, "\"", 537, 2);
            WriteAttributeValue("", 475, "data:image/jpeg;base64,", 475, 23, true);
#line 15 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
WriteAttributeValue("", 498, Convert.ToBase64String(@Model.Image), 498, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 157, true);
            WriteLiteral(" />\r\n            <div class=\"book_desc\">\r\n                <div class=\"h4\">Author</div>\r\n                <div class=\"h4 text-secondary\">\r\n                    ");
            EndContext();
            BeginContext(695, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d467e7d426243fcb75939aa624049bd", async() => {
                BeginContext(779, 38, false);
#line 19 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                                                                                  Write(authorService.Get(Model.AuthorId).Name);

#line default
#line hidden
                EndContext();
                BeginContext(817, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(819, 41, false);
#line 19 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                                                                                                                          Write(authorService.Get(Model.AuthorId).Surname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                                    WriteLiteral(authorService.Get(Model.AuthorId).Id);

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
            BeginContext(864, 120, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"h4\">Genre</div>\r\n                <div class=\"h5 text-secondary\">");
            EndContext();
            BeginContext(985, 11, false);
#line 23 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                          Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(996, 99, true);
            WriteLiteral("</div>\r\n                <div class=\"h4\">Rate</div>\r\n                <div class=\"h5 text-secondary\">");
            EndContext();
            BeginContext(1096, 10, false);
#line 25 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                          Write(Model.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 107, true);
            WriteLiteral("</div>\r\n                <div class=\"h4\">Rates amount</div>\r\n                <div class=\"h5 text-secondary\">");
            EndContext();
            BeginContext(1214, 17, false);
#line 27 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                          Write(Model.RatesAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 26, true);
            WriteLiteral("</div>\r\n\r\n                ");
            EndContext();
            BeginContext(1257, 789, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ee7f575af74635916cebedfa76295c", async() => {
                BeginContext(1321, 72, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(1393, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b6eede85fee4f6d807a9dcf8d1e9fb1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 31 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1429, 100, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(1529, 299, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b648e42a5544acbbea4ad0368695fba", async() => {
                    BeginContext(1608, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 35 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                             for (int i = 1; i <= 5; i++)
                            {

#line default
#line hidden
                    BeginContext(1700, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(1732, 30, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90de4000b3fc46e2a4233ac936e85605", async() => {
                        BeginContext(1752, 1, false);
#line 37 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                              Write(i);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 37 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1762, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 38 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                            }

#line default
#line hidden
                    BeginContext(1795, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 34 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1828, 211, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Rate Book\" class=\"btn btn-success\" />\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2046, 126, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-12 col-md-7 col-lg-8 d-flex flex-column pt-3\">\r\n            <h1>");
            EndContext();
            BeginContext(2173, 11, false);
#line 48 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2184, 19, true);
            WriteLiteral("</h1>\r\n            ");
            EndContext();
            BeginContext(2203, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7dc75e3f1734df3857826e386a76974", async() => {
                BeginContext(2257, 8, true);
                WriteLiteral("Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                           WriteLiteral(Model.Id);

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
            BeginContext(2269, 87, true);
            WriteLiteral("\r\n            <div class=\"h2\">Description</div>\r\n            <p class=\"text-secondary\">");
            EndContext();
            BeginContext(2357, 17, false);
#line 51 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
                                 Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2374, 34, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 54 "E:\GitHUb\PPS2\BookLibrary\BookLibrary\Views\Home\GetBookInfo.cshtml"
      await Html.RenderPartialAsync("CommentPartial", Model.Id);

#line default
#line hidden
            BeginContext(2475, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTO.BookDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
