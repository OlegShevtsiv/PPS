#pragma checksum "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "584e72ab598d981281f6f065708b01da7289aa21"
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
#line 1 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess.Models;

#line default
#line hidden
#line 4 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using DataAccess;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"584e72ab598d981281f6f065708b01da7289aa21", @"/Views/Home/GetAuthorInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a812df736c114cf8d16a5076685ff0ecc13143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAuthorInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\Home\GetAuthorInfo.cshtml"
  
    ViewData["Title"] = "Get author info";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 2144, true);
            WriteLiteral(@"
<div class=""container pt-3 pb-4"">
    <div class=""row"">
        <div class=""col-12 col-md-5 col-lg-4 d-flex flex-column pt-3"">
            <img src="""" alt=""book (here must be the name of book)"" class=""w-100"">
            <div class=""book_desc"">
                <div class=""h4"">Author name</div>
                <div class=""h5 text-secondary"">lorem</div>
                <div class=""h4"">Genre</div>
                <div class=""h5 text-secondary"">lorem</div>
            </div>
        </div>
        <div class=""col-12 col-md-7 col-lg-8 d-flex flex-column pt-3"">
            <h1>Author name</h1>
            <a href=""#"">Download</a>
            <div class=""h2"">Description</div>
            <p class=""text-secondary"">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Placeat, omnis aspernatur quidem magni consectetur quam nihil debitis sit aut culpa adipisci sequi nisi at dignissimos ratione quod, quo, quos numquam.
                Lorem ipsum dolor sit amet, consectetur adipis");
            WriteLiteral(@"icing elit. Placeat, omnis aspernatur quidem magni consectetur quam nihil debitis sit aut culpa adipisci sequi nisi at dignissimos ratione quod, quo, quos numquam.
            </p>
            <div class=""more_books d-flex flex-wrap"">
                <div class=""col-6 col-md-3"">
                    <a class=""card"">
                        <img src=""..."" class=""card-img-top"" alt=""..."">
                    </a>
                </div>
                <div class=""col-6 col-md-3"">
                    <a class=""card"">
                        <img src=""..."" class=""card-img-top"" alt=""..."">
                    </a>
                </div>
                <div class=""col-6 col-md-3"">
                    <a class=""card"">
                        <img src=""..."" class=""card-img-top"" alt=""..."">
                    </a>
                </div>
                <div class=""col-6 col-md-3"">
                    <a class=""card"">
                        <img src=""..."" class=""card-img-top"" alt=""..."">
            ");
            WriteLiteral("        </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
