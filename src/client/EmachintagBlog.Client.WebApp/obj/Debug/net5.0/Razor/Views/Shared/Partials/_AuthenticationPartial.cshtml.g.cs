#pragma checksum "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\Shared\Partials\_AuthenticationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e9ea3a68266d576cc8a8c8604fd6e8e99b29c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__AuthenticationPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_AuthenticationPartial.cshtml")]
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
#line 1 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\_ViewImports.cshtml"
using EmachintagBlog.Client.WebApp.ViewModels.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e9ea3a68266d576cc8a8c8604fd6e8e99b29c2", @"/Views/Shared/Partials/_AuthenticationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9186bf7def3bc46ec08f0b06b3090af983b36d47", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__AuthenticationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\Shared\Partials\_AuthenticationPartial.cshtml"
 if (currentUser.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Merhaba ");
#nullable restore
#line 5 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\Shared\Partials\_AuthenticationPartial.cshtml"
           Write(currentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <a href=\"/Authentication/LogOut\">????k???? Yap</a>\r\n");
#nullable restore
#line 7 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\Shared\Partials\_AuthenticationPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin:5px; padding:5px;\">\r\n        <a href=\"/Authentication/Login\">Giri?? Yap</a>\r\n        <a href=\"/Authentication/Register\">Kaydol</a>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Elmar\Documents\WebProjeBlog\src\client\EmachintagBlog.Client.WebApp\Views\Shared\Partials\_AuthenticationPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public EmachintagBlog.Client.WebApp.Common.CurrentUser currentUser { get; private set; }
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
