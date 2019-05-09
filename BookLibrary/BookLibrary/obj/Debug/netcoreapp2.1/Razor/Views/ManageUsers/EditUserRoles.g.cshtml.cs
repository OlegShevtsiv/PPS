#pragma checksum "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766b8e6c6cc03309e61641b2fc871851fdfdf2e1"
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
#line 1 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766b8e6c6cc03309e61641b2fc871851fdfdf2e1", @"/Views/ManageUsers/EditUserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a812df736c114cf8d16a5076685ff0ecc13143", @"/Views/_ViewImports.cshtml")]
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
#line 3 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
  
    ViewData["Title"] = "Changing user roles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(203, 30, true);
            WriteLiteral("\r\n<h2>Changing roles for user ");
            EndContext();
            BeginContext(234, 15, false);
#line 8 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
                       Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(249, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(258, 880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24a948e67864de792cadc18da79c539", async() => {
                BeginContext(305, 40, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 345, "\"", 366, 1);
#line 11 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
WriteAttributeValue("", 353, Model.UserId, 353, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(367, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
                BeginContext(676, 30, true);
                WriteLiteral("    <div class=\"form-group\">\r\n");
                EndContext();
#line 20 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
                BeginContext(773, 79, true);
                WriteLiteral("        <label class=\"container\">\r\n            <input type=\"radio\" name=\"roles\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 852, "\"", 870, 1);
#line 23 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
WriteAttributeValue("", 860, role.Name, 860, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(871, 21, true);
                WriteLiteral("\r\n                   ");
                EndContext();
                BeginContext(894, 64, false);
#line 24 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
               Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(959, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(961, 9, false);
#line 24 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
                                                                                  Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(970, 73, true);
                WriteLiteral("\r\n                <span class=\"checkmark\"></span>\r\n            </label>\r\n");
                EndContext();
#line 27 "C:\Users\Admin\Desktop\PPS\BookLibrary\BookLibrary\Views\ManageUsers\EditUserRoles.cshtml"
        }

#line default
#line hidden
                BeginContext(1054, 77, true);
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
            BeginContext(1138, 2, true);
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
