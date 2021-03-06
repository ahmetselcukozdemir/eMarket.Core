#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c83be3bab6a60322fabb29875221a5c95701dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HotProducts), @"mvc.1.0.view", @"/Views/Shared/_HotProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c83be3bab6a60322fabb29875221a5c95701dd", @"/Views/Shared/_HotProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1729fd9a115e85efc2ddb5530ea2e29e01a67c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HotProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eMarket.Core.Web.UI.Models.Home.HomeProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/notimages.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""product-area most-popular section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-title"">
                    <h2>Son Eklenenler</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""owl-carousel popular-slider"">
                    <!-- Start Single Product -->
");
#nullable restore
#line 15 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                      
                        foreach (var item in Model.HotProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-product\">\n                                <div class=\"product-img\">\n");
#nullable restore
#line 20 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                     
                                       var imageHome = item.ProductImages.Where(x => x.IsHome == true).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <a");
            BeginWriteAttribute("href", " href=\"", 931, "\"", 967, 2);
            WriteAttributeValue("", 938, "/Shop/Details/", 938, 14, true);
#nullable restore
#line 22 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
WriteAttributeValue("", 952, item.ProductId, 952, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 23 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                            if (imageHome != null)
                                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0c83be3bab6a60322fabb29875221a5c95701dd6434", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1159, "~/images/products/", 1159, 18, true);
#nullable restore
#line 25 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
AddHtmlAttributeValue("", 1177, imageHome.Url, 1177, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                                               <span class=\"out-of-stock\">Hot</span>\n");
#nullable restore
#line 28 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                           }
                                           else
                                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0c83be3bab6a60322fabb29875221a5c95701dd8631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                               <span class=\"out-of-stock\">Hot</span>\n");
#nullable restore
#line 33 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       </a>\n");
            WriteLiteral("                                    \n                                    <div class=\"button-head\">\n                                        <div class=\"product-action\">\n");
            WriteLiteral("                                        </div>\n                                        <div class=\"product-action-2\">\n                                            <a title=\"Detaylı İncele\"");
            BeginWriteAttribute("href", " href=\"", 2693, "\"", 2729, 2);
            WriteAttributeValue("", 2700, "/Shop/Details/", 2700, 14, true);
#nullable restore
#line 44 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
WriteAttributeValue("", 2714, item.ProductId, 2714, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detaylı İncele</a>\n                                        </div>\n                                    </div>\n                                </div>\n                                <div class=\"product-content\">\n                                    <h3><a");
            BeginWriteAttribute("href", " href=\"", 2983, "\"", 3019, 2);
            WriteAttributeValue("", 2990, "/Shop/Details/", 2990, 14, true);
#nullable restore
#line 49 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
WriteAttributeValue("", 3004, item.ProductId, 3004, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                                    <div class=\"product-price\">\n");
            WriteLiteral("                                        <span>");
#nullable restore
#line 52 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                                         Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 56 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Shared\_HotProducts.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- End Single Product -->\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
