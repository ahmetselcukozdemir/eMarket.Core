#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2607e86948f9f704402b4c374f5fa37deceeb66c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Default), @"mvc.1.0.view", @"/Views/Admin/Default.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\_ViewImports.cshtml"
using eMarket.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\_ViewImports.cshtml"
using eMarket.Web.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2607e86948f9f704402b4c374f5fa37deceeb66c", @"/Views/Admin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add223f6c8495c78f23a29613f48ee5e2b34c54c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
  
    ViewData["Title"] = "Default";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\" >\r\n    <!-- Animated -->\r\n    <div class=\"animated fadeIn\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
              
                if (@ViewBag.member_IsAdmin == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-3"">
                                        <i class=""pe-7s-clock""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 23 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.UnapprovedProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">onaylanmamış ürün</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-4"">
                                        <i class=""pe-7s-check""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 41 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.ApprovedProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">onaylı ürün</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-1"">
                                        <i class=""pe-7s-mail-open-file""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 58 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.readMessageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">Okunmuş Mesaj</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-2"">
                                        <i class=""pe-7s-mail""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 76 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.unReadMessageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">okunmamış mesaj</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 84 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"


                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
              
                if (@ViewBag.member_IsAdmin == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-1"">
                                        <i class=""pe-7s-check""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 101 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.ApprovedProductAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">onaylanmış ürün</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-1"">
                                        <i class=""pe-7s-clock""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 118 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.UnApprovedProductAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">onay bekleyen ürün</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-1"">
                                        <i class=""pe-7s-mail-open-file""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 135 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.readMessageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">Okunmuş mesaj</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-2"">
                                        <i class=""pe-7s-mail""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 153 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.unReadMessageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">okunmamış mesaj</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-4"">
                                        <i class=""pe-7s-users""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 170 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.MemberCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">üye</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-4"">
                                        <i class=""pe-7s-user""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 187 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">kullanıcı</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-4"">
                                        <i class=""pe-7s-menu""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 204 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.CategoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">üst kategori</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""stat-widget-five"">
                                    <div class=""stat-icon dib flat-color-4"">
                                        <i class=""pe-7s-network""></i>
                                    </div>
                                    <div class=""stat-content"">
                                        <div class=""text-left dib"">
                                            <div class=""stat-text""><span class=""count"">");
#nullable restore
#line 221 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                                                                                  Write(ViewBag.SubCategoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""stat-heading"">alt kategori</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 229 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"container\">\r\n\r\n            <p> Merhaba, sayın ");
#nullable restore
#line 236 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\Default.cshtml"
                          Write(ViewBag.member_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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