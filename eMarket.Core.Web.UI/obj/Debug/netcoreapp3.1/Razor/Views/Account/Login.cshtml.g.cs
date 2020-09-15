#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4bd6ee4e0f53fe3c97141b961f5ffcaf0df4457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\_ViewImports.cshtml"
using eMarket.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\_ViewImports.cshtml"
using eMarket.Web.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bd6ee4e0f53fe3c97141b961f5ffcaf0df4457", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1729fd9a115e85efc2ddb5530ea2e29e01a67c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
Write(Html.Partial("_MenuTwoLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--/ End Header Inner -->\n</header>\n\n\n<main class=\"login-form\" style=\"margin-top: 80px; margin-bottom: 80px;\">\n    <div class=\"container\">\n        <div class=\"row justify-content-center\">\n            <div class=\"col-md-12\">\n");
#nullable restore
#line 16 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                  
                    if (!string.IsNullOrEmpty(@ViewBag.LTLD))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-muted\">Merhaba, daha önce ");
#nullable restore
#line 19 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                                                            Write(ViewBag.LTLD);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tarihinde giriş sisteme giriş yapmışsınız.</p>\n");
#nullable restore
#line 20 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\n                    <div class=\"card-header\">Giriş Yap</div>\n                  \n                    <div class=\"card-body\">\n");
#nullable restore
#line 27 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                          
                            if (@ViewBag.ErrorMessageLogin != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\n                                    <a class=\"close\" data-dismiss=\"alert\" href=\"#\">×</a>");
#nullable restore
#line 31 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                                                                                   Write(ViewBag.ErrorMessageLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 33 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n");
#nullable restore
#line 35 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                         using (Html.BeginForm("Login", "Account", FormMethod.Post))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-group row"">
                                <label for=""email_address"" class=""col-md-4 col-form-label text-md-right"">E-Mail Adresiniz</label>
                                <div class=""col-md-6"">
                                    <input type=""text"" id=""email_address"" class=""form-control"" name=""Email"" required autofocus>
                                </div>
                            </div>
");
            WriteLiteral(@"                            <div class=""form-group row"">
                                <label for=""password"" class=""col-md-4 col-form-label text-md-right"">Şifre</label>
                                <div class=""col-md-6"">
                                    <input type=""password"" id=""password"" class=""form-control"" name=""password"" required>
                                </div>
                            </div>
");
            WriteLiteral(@"                            <div class=""col-md-6 offset-md-4"">
                                <input type=""submit"" class=""btn btn-primary btn-sm"" value=""Giriş Yap""/>
                                <a href=""#"">
                                    <strong>|</strong> Şifremi Unuttum
                                </a>
                            </div>
");
#nullable restore
#line 58 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Account\Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    </div>\n\n</main>");
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