#pragma checksum "E:\projects\login_aspnet_core\login_aspnet_core\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47df5120bf4cd8151694957d8311f5dd42c515b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Index.cshtml", typeof(AspNetCore.Views_Role_Index))]
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
#line 1 "E:\projects\login_aspnet_core\login_aspnet_core\Views\_ViewImports.cshtml"
using login_aspnet_core;

#line default
#line hidden
#line 2 "E:\projects\login_aspnet_core\login_aspnet_core\Views\_ViewImports.cshtml"
using LoginData.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47df5120bf4cd8151694957d8311f5dd42c515b", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e3a35e598d3dcec1db9a3bf30b1990ccbfd14b", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginASPNETCore.Views.Role.IndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 180, true);
            WriteLiteral("\r\n<div>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <td>Name</td>\r\n                <td>Description</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 12 "E:\projects\login_aspnet_core\login_aspnet_core\Views\Role\Index.cshtml"
             foreach (var obj in @Model.Roles)
            {

#line default
#line hidden
            BeginContext(289, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(336, 8, false);
#line 15 "E:\projects\login_aspnet_core\login_aspnet_core\Views\Role\Index.cshtml"
                   Write(obj.Name);

#line default
#line hidden
            EndContext();
            BeginContext(344, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(376, 15, false);
#line 16 "E:\projects\login_aspnet_core\login_aspnet_core\Views\Role\Index.cshtml"
                   Write(obj.Description);

#line default
#line hidden
            EndContext();
            BeginContext(391, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "E:\projects\login_aspnet_core\login_aspnet_core\Views\Role\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(436, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginASPNETCore.Views.Role.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
