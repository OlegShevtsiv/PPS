#pragma checksum "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca57276bce230287816fde2604222295ae946e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUsers_EditUserRoles), @"mvc.1.0.view", @"/Views/ManageUsers/EditUserRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageUsers/EditUserRoles.cshtml", typeof(AspNetCore.Views_ManageUsers_EditUserRoles))]
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
#line 1 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca57276bce230287816fde2604222295ae946e0", @"/Views/ManageUsers/EditUserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUsers_EditUserRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibrary.ViewModels.ManageUsers.ChangeRoleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
  
    ViewData["Title"] = "Changing user roles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(203, 43, true);
            WriteLiteral("\r\n<h2 class=\"mt-5\">Changing roles for user ");
            EndContext();
            BeginContext(247, 15, false);
#line 8 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
                                    Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(262, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(271, 813, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb45cbe440504301be51646e49194d9e", async() => {
                BeginContext(318, 40, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 358, "\"", 379, 1);
#line 11 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
WriteAttributeValue("", 366, Model.UserId, 366, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(380, 35, true);
                WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n");
                EndContext();
#line 13 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
                BeginContext(482, 195, true);
                WriteLiteral("        <div class=\"d-flex\">\r\n            <div class=\"input-group-prepend\">\r\n                <div class=\"input-group-text bg-white border-0\">\r\n                    <input type=\"radio\" name=\"roles\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 677, "\"", 695, 1);
#line 18 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
WriteAttributeValue("", 685, role.Name, 685, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(696, 29, true);
                WriteLiteral("\r\n                           ");
                EndContext();
                BeginContext(727, 64, false);
#line 19 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
                       Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(792, 153, true);
                WriteLiteral(">\r\n                        <span class=\"checkmark\"></span>\r\n                    </div>\r\n                </div>\r\n\r\n            <label class=\"pl-3 h4 m-0\">");
                EndContext();
                BeginContext(946, 9, false);
#line 24 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
                                  Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(955, 30, true);
                WriteLiteral("</label>\r\n            </div>\r\n");
                EndContext();
#line 26 "C:\Users\Admin\Desktop\PPS2\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
            }

#line default
#line hidden
                BeginContext(1000, 77, true);
                WriteLiteral("    </div>\r\n    <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1084, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.ViewModels.ManageUsers.ChangeRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
