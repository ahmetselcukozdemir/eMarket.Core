#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b725f06ec05408d6ab577e8ca9429da9549a48d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BlogAdd), @"mvc.1.0.view", @"/Views/Admin/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b725f06ec05408d6ab577e8ca9429da9549a48d4", @"/Views/Admin/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1729fd9a115e85efc2ddb5530ea2e29e01a67c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eMarket.Core.Web.UI.Models.Blog.BlogModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("Admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\BlogAdd.cshtml"
  
    ViewData["Title"] = "AddBlog";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <strong class=""card-title"">Yeni Yazı Ekle</strong>
                        <hr>
                    </div>
");
#nullable restore
#line 15 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\BlogAdd.cshtml"
                      
                        if (ViewBag.ErrorMessage != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""alert-group"">
                                        <div class=""alert alert-danger alert-dismissable"">
                                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                            <strong>Hata !</strong> ");
#nullable restore
#line 23 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\BlogAdd.cshtml"
                                                               Write(ViewBag.ErrorMessagee);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 28 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\BlogAdd.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body\">\n                        <div id=\"pay-invoice\">\n                            <div class=\"card-body\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b725f06ec05408d6ab577e8ca9429da9549a48d47450", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""cc-payment"" class=""control-label mb-1"">Başlık</label>
                                        <input id=""cc-payment"" name=""Title"" type=""text"" class=""form-control"" aria-required=""true"" aria-invalid=""false"" >
                                    </div>
                                    <div class=""form-group has-success"">
                                        <label for=""cc-name"" class=""control-label mb-1"">Açıklama</label>
                                        <input id=""cc-name"" name=""Description"" type=""text"" class=""form-control cc-name valid"" data-val=""true"" aria-required=""true"">
                                    </div>
                                    <div class=""form-group has-success"">
                                        <label for=""cc-name"" class=""control-label mb-1"">Fotoğraf</label>
                                        <input type=""file"" name=""file"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 2553, "\"", 2558, 0);
                EndWriteAttribute();
                WriteLiteral(@"/>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""cc-number"" class=""control-label mb-1"">İçerik</label>
                                        <textarea type=""text"" name=""Content"" id=""editor"" placeholder=""Açıklama.."" class=""form-control""></textarea>

                                    </div>
                                    <div>
                                        <input type=""submit"" class=""btn btn-success btn-lg"" value=""Ekle""/>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b725f06ec05408d6ab577e8ca9429da9549a48d411290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\n    CKEDITOR.replace(\'editor\');\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eMarket.Core.Web.UI.Models.Blog.BlogModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
