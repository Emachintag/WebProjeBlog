#pragma checksum "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91ff7e8bd82b508a9cdef6efa93cf5c0b1f381a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_About_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/About/Delete.cshtml")]
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
#line 1 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91ff7e8bd82b508a9cdef6efa93cf5c0b1f381a", @"/Areas/Admin/Views/About/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf914920e042c056ec337de1b56c57206c2bf9cd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_About_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_MainAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <h2>Silmek istediğinize emin misiniz?</h2>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91ff7e8bd82b508a9cdef6efa93cf5c0b1f381a4634", async() => {
                WriteLiteral("\r\n\r\n            <hr />\r\n            <div class=\"container-fluid\">\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>İsim</h5>\r\n                    <label>");
#nullable restore
#line 18 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Mesaj</h5>\r\n                    <label>");
#nullable restore
#line 23 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Email</h5>\r\n                    <label>");
#nullable restore
#line 28 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Telefon</h5>\r\n                    <label>");
#nullable restore
#line 33 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Adres</h5>\r\n                    <label>");
#nullable restore
#line 38 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Instagram</h5>\r\n                    <label>");
#nullable restore
#line 43 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.InstagramLink);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Facebook</h5>\r\n                    <label>");
#nullable restore
#line 48 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.FacebookLink);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <h5>Twitter</h5>\r\n                    <label>");
#nullable restore
#line 53 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
                      Write(Model.TwitterLink);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">

                    <div class=""col-md-6"">
                        <button type=""submit"" class=""btn btn-primary btn-user btn-block"">Sil</button>
                    </div>

                    <div class=""col-md-6"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 1999, "\"", 2035, 1);
#nullable restore
#line 66 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
WriteAttributeValue("", 2006, Url.Action("Index", "About"), 2006, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary btn-user btn-block\">Vazgeç</a>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\About\Delete.cshtml"
AddHtmlAttributeValue("", 240, Url.Action("DeleteConfirmed", "About", new { id = Model.Id }), 240, 62, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; }
    }
}
#pragma warning restore 1591
