#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09385880c786d732b9db717c09ee0c19078cd8ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MenuOneLayout), @"mvc.1.0.view", @"/Views/Home/_MenuOneLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09385880c786d732b9db717c09ee0c19078cd8ad", @"/Views/Home/_MenuOneLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1729fd9a115e85efc2ddb5530ea2e29e01a67c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__MenuOneLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eMarket.Core.Web.UI.Models.Home.HomeProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header-inner"">
    <div class=""container"">
        <div class=""cat-nav-head"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""all-category"">
                        <h3 class=""cat-heading""><i class=""fa fa-bars"" aria-hidden=""true""></i>Kategoriler</h3>
                        <ul class=""main-category"">
");
#nullable restore
#line 11 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                 foreach (var category in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"test\">\n\n                                        ");
#nullable restore
#line 15 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                   Write(Html.Hidden("catID", category.categoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <a href=\"#\">");
#nullable restore
#line 16 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\" test fa fa-angle-right\" aria-hidden=\"true\"></i></a>\n                                        <ul class=\"sub-category\">\n");
#nullable restore
#line 18 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                             foreach (var subcategory in Model.SubCategories)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                                 if (subcategory.CategoryID == category.categoryID)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1246, "\"", 1295, 3);
            WriteAttributeValue("", 1253, "/Shop/Products/", 1253, 15, true);
#nullable restore
#line 22 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
WriteAttributeValue("", 1268, subcategory.subCategoryID, 1268, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1294, "/", 1294, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                                                                                        Write(subcategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 23 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\n\n\n                                    </li>\n");
#nullable restore
#line 30 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Home\_MenuOneLayout.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-9 col-12"">
                    <div class=""menu-area"">
                        <!-- Main Menu -->
                        <nav class=""navbar navbar-expand-lg"">
                            <div class=""navbar-collapse"">
                                <div class=""nav-inner"">
                                    <ul class=""nav main-menu menu navbar-nav"">
                                        <li id=""Home"" ><a href=""/Home/Index/"">Anasayfa</a></li>
                                        <li ><a href=""/Shop/Products/"">Ürünler</a></li>
                                        <li>
                                            <a href=""#"">Mağazalar<i class=""ti-angle-down""></i></a>
                                            <ul class=""dropdown"">
                                                <li id=""Sellers""><a href=""/Shop/Sellers/"">Mağazalar</a></li>
                          ");
            WriteLiteral(@"                      <li><a href=""cart.html"">Mağaza Aç</a></li>
                                            </ul>
                                        </li>
                                        <li><a href=""#"">Blog</a></li>
                                        <li><a href=""contact.html"">İletişim</a></li>
                                    </ul>
                                </div>
                            </div>
                        </nav>
                        <!--/ End Main Menu -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('.test a.test').on(""click"", function (e) {
            $(this).next('sub-category').toggle();
            e.stopPropagation();
            e.preventDefault();
        });
    });}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eMarket.Core.Web.UI.Models.Home.HomeProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
