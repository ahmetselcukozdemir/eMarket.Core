#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8600d0bf2c2b6f69206700a5b21f05893ca08b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MyInfoEdit), @"mvc.1.0.view", @"/Views/Admin/MyInfoEdit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8600d0bf2c2b6f69206700a5b21f05893ca08b71", @"/Views/Admin/MyInfoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1729fd9a115e85efc2ddb5530ea2e29e01a67c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MyInfoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eMarket.Core.Entity.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
  
    ViewData["Title"] = "MyInfoEdit";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    var success_message = Context.Session.GetString("SuccessUpdateMessage");
    var error_message = Context.Session.GetString("ErrorUpdateMessage");
    var url = @Context.Request.GetEncodedUrl();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8600d0bf2c2b6f69206700a5b21f05893ca08b714817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8600d0bf2c2b6f69206700a5b21f05893ca08b715854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/3.3.4/jquery.inputmask.bundle.min.js\"></script>\n");
#nullable restore
#line 15 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
  

    if (error_message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""container"">
            <div class=""alert alert-danger"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <strong>Hatalı !</strong> ");
#nullable restore
#line 21 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
                                     Write(error_message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 24 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
    }
    if (success_message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">

            <div class=""alert alert-success"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <strong>Başarılı !</strong> ");
#nullable restore
#line 31 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
                                       Write(success_message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n\n        </div>\n");
#nullable restore
#line 36 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""content"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <strong>Kişisel Bilgilerim</strong> <small> Düzenle</small>
                    </div>
                    <div class=""card-body card-block"">
");
#nullable restore
#line 49 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
                          
                            using (Html.BeginForm("MyInfoEdit", "Admin", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
                           Write(Html.Hidden("url", url));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""form-group"">
                                    <label class="" form-control-label"">Ad </label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-user-circle""></i></div>
                                        <input class=""form-control"" name=""Name""");
            BeginWriteAttribute("value", " value=\"", 2337, "\"", 2356, 1);
#nullable restore
#line 57 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 2345, Model.Name, 2345, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Soyad </label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-user-circle""></i></div>
                                        <input class=""form-control"" name=""Surname""");
            BeginWriteAttribute("value", " value=\"", 2839, "\"", 2861, 1);
#nullable restore
#line 64 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 2847, Model.Surname, 2847, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Email</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-mail-reply""></i></div>
                                        <input class=""form-control"" name=""Email""");
            BeginWriteAttribute("value", " value=\"", 3340, "\"", 3360, 1);
#nullable restore
#line 71 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 3348, Model.Email, 3348, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Şifre</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-user-secret""></i></div>
                                        <input class=""form-control"" name=""Password""");
            BeginWriteAttribute("value", " value=\"", 3843, "\"", 3866, 1);
#nullable restore
#line 78 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 3851, Model.Password, 3851, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Adres</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-address-book""></i></div>
                                        <input class=""form-control"" name=""Address""");
            BeginWriteAttribute("value", " value=\"", 4349, "\"", 4371, 1);
#nullable restore
#line 85 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 4357, Model.Address, 4357, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <small class=""form-text text-muted"">Müşterilerini seni daha yakından tanıyabilmesi için bir adres bilgisi girebilirsin.</small>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Mağaza Slogan ;</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-shopping-basket""></i></div>
                                        <input class=""form-control"" name=""Slogan""");
            BeginWriteAttribute("value", " value=\"", 5030, "\"", 5051, 1);
#nullable restore
#line 93 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 5038, Model.Slogan, 5038, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <small class=""form-text text-muted"">Mağazan için bir slogan belirleyebilirsin.</small>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Mağaza Adı ;</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-shopping-basket""></i></div>
                                        <input class=""form-control"" name=""StoreName""");
            BeginWriteAttribute("value", " value=\"", 5669, "\"", 5693, 1);
#nullable restore
#line 101 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 5677, Model.StoreName, 5677, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <small class=""form-text text-muted"">Mağazan için bir isim belirleyebilirsin.</small>
                                </div>
                                <div class=""form-group"">
                                    <label class="" form-control-label"">Telefon </label>
                                    <div class=""input-group"">
                                        <div class=""input-group-addon""><i class=""fa fa-phone""></i></div>
                                        <input class=""form-control"" name=""Phone""");
            BeginWriteAttribute("value", " value=\"", 6291, "\"", 6311, 1);
#nullable restore
#line 109 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
WriteAttributeValue("", 6299, Model.Phone, 6299, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    </div>\n                                </div>\n                                <input type=\"submit\" class=\"btn btn-success\" value=\"Bilgilerimi Güncelle\" />\n");
#nullable restore
#line 113 "C:\Users\ahmet\source\repos\eMarket\eMarket.Core\eMarket.Core.Web.UI\Views\Admin\MyInfoEdit.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    window.setTimeout(function () {
        $("".alert"").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 5000);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eMarket.Core.Entity.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591