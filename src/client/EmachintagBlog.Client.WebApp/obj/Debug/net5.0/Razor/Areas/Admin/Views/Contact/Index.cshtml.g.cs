#pragma checksum "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b89f361b2e1be30658598e778ff43c861f03ae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b89f361b2e1be30658598e778ff43c861f03ae9", @"/Areas/Admin/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf914920e042c056ec337de1b56c57206c2bf9cd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contacts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Mesajlar";
    Layout = "~/Areas/Admin/Views/Shared/_MainAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Mesajlar</h1>
    </div>

    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <div id=""dataTable_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>İsim</th>
                                <th>E-Posta</th>
                                <th>Başlık</th>
                                <th>Fonksiyon</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 30 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                             foreach (var mesaj in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 33 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                                   Write(mesaj.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 34 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                                   Write(mesaj.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                                      
                                        var subjectContent = string.Empty;
                                        if (mesaj.Subject.Length > 50)
                                        {
                                            subjectContent = mesaj.Subject.Substring(0, 50);
                                        }
                                        else
                                        {
                                            subjectContent = mesaj.Subject;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 46 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                                   Write(subjectContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"row\">\r\n                                            <div class=\"col-sm-4\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2194, "\"", 2256, 1);
#nullable restore
#line 50 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2201, Url.Action("Detail", "Contact", new { id = mesaj.Id }), 2201, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">Detay</a>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 55 "C:\Users\Elmar\Documents\EmachintagBlog\src\client\EmachintagBlog.Client.WebApp\Areas\Admin\Views\Contact\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contacts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
