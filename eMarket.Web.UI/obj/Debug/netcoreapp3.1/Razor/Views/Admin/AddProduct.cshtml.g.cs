#pragma checksum "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e239f1bd793a6a139ab599643cc8ed907c3b6213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddProduct), @"mvc.1.0.view", @"/Views/Admin/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e239f1bd793a6a139ab599643cc8ed907c3b6213", @"/Views/Admin/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add223f6c8495c78f23a29613f48ee5e2b34c54c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eMarket.Entity.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlcountry"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlstate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SubCategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("msform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\'text/javascript\' src=\'https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js\'></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e239f1bd793a6a139ab599643cc8ed907c3b62137929", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e239f1bd793a6a139ab599643cc8ed907c3b62138968", async() => {
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
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/3.3.4/jquery.inputmask.bundle.min.js""></script>
<style>
    * {
        margin: 0;
        padding: 0
    }

    html {
        height: 100%
    }

    #grad1 {
        background-color: : #9C27B0;
    }

    #msform {
        text-align: center;
        position: relative;
        margin-top: 20px
    }

        #msform fieldset .form-card {
            background: white;
            border: 0 none;
            border-radius: 0px;
            box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
            padding: 20px 40px 30px 40px;
            box-sizing: border-box;
            width: 94%;
            margin: 0 3% 20px 3%;
            position: relative
        }

        #msform fieldset {
            background: white;
            border: 0 none;
            border-radius: 0.5rem;
            box-sizing: border-box;
            width: 100%;
            margin: 0;
            padding-bottom: 20px;
 ");
            WriteLiteral(@"           position: relative
        }

            #msform fieldset:not(:first-of-type) {
                display: none
            }

            #msform fieldset .form-card {
                text-align: left;
                color: #9E9E9E
            }

        #msform input,
        #msform textarea {
            padding: 0px 8px 4px 8px;
            border: none;
            border-bottom: 1px solid #ccc;
            border-radius: 0px;
            margin-bottom: 25px;
            margin-top: 2px;
            width: 100%;
            box-sizing: border-box;
            font-family: montserrat;
            color: #2C3E50;
            font-size: 16px;
            letter-spacing: 1px
        }

            #msform input:focus,
            #msform textarea:focus {
                -moz-box-shadow: none !important;
                -webkit-box-shadow: none !important;
                box-shadow: none !important;
                border: none;
                font-weight: bold;");
            WriteLiteral(@"
                border-bottom: 2px solid skyblue;
                outline-width: 0
            }

        #msform .action-button {
            width: 100px;
            background: skyblue;
            font-weight: bold;
            color: white;
            border: 0 none;
            border-radius: 0px;
            cursor: pointer;
            padding: 10px 5px;
            margin: 10px 5px
        }

            #msform .action-button:hover,
            #msform .action-button:focus {
                box-shadow: 0 0 0 2px white, 0 0 0 3px skyblue
            }

        #msform .action-button-previous {
            width: 100px;
            background: #616161;
            font-weight: bold;
            color: white;
            border: 0 none;
            border-radius: 0px;
            cursor: pointer;
            padding: 10px 5px;
            margin: 10px 5px
        }

            #msform .action-button-previous:hover,
            #msform .action-button-previous:focus");
            WriteLiteral(@" {
                box-shadow: 0 0 0 2px white, 0 0 0 3px #616161
            }

    select.list-dt {
        border: none;
        outline: 0;
        border-bottom: 1px solid #ccc;
        padding: 2px 5px 3px 5px;
        margin: 2px
    }

        select.list-dt:focus {
            border-bottom: 2px solid skyblue
        }

    .card {
        z-index: 0;
        border: none;
        border-radius: 0.5rem;
        position: relative
    }

    .fs-title {
        font-size: 25px;
        color: #2C3E50;
        margin-bottom: 10px;
        font-weight: bold;
        text-align: left
    }

    #progressbar {
        margin-bottom: 30px;
        overflow: hidden;
        color: lightgrey
    }

        #progressbar .active {
            color: #000000
        }

        #progressbar li {
            list-style-type: none;
            font-size: 12px;
            width: 25%;
            float: left;
            position: relative
        }

        #progres");
            WriteLiteral(@"sbar #account:before {
            font-family: FontAwesome;
            content: ""\f023""
        }

        #progressbar #personal:before {
            font-family: FontAwesome;
            content: ""\f007""
        }

        #progressbar #payment:before {
            font-family: FontAwesome;
            content: ""\f09d""
        }

        #progressbar #confirm:before {
            font-family: FontAwesome;
            content: ""\f00c""
        }

        #progressbar li:before {
            width: 50px;
            height: 50px;
            line-height: 45px;
            display: block;
            font-size: 18px;
            color: #ffffff;
            background: lightgray;
            border-radius: 50%;
            margin: 0 auto 10px auto;
            padding: 2px
        }

        #progressbar li:after {
            content: '';
            width: 100%;
            height: 2px;
            background: lightgray;
            position: absolute;
            left:");
            WriteLiteral(@" 0;
            top: 25px;
            z-index: -1
        }

        #progressbar li.active:before,
        #progressbar li.active:after {
            background: skyblue
        }

    .radio-group {
        position: relative;
        margin-bottom: 25px
    }

    .radio {
        display: inline-block;
        width: 204;
        height: 104;
        border-radius: 0;
        background: lightblue;
        box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
        box-sizing: border-box;
        cursor: pointer;
        margin: 8px 2px
    }

        .radio:hover {
            box-shadow: 2px 2px 2px 2px rgba(0, 0, 0, 0.3)
        }

        .radio.selected {
            box-shadow: 1px 1px 2px 2px rgba(0, 0, 0, 0.1)
        }

    .fit-image {
        width: 100%;
        object-fit: cover
    }
</style>
<script src=""https://cdn.jsdelivr.net/npm/jquery.flot@0.8.3/jquery.flot.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/flot-pie@1.0.0/src/jquery.flot.pie");
            WriteLiteral(@".min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/flot-spline@0.0.1/js/jquery.flot.spline.min.js""></script>
<script type='text/javascript' src='https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js'></script>

<script type='text/javascript'>
    $(document).ready(function () {

        var current_fs, next_fs, previous_fs; //fieldsets
        var opacity;

        $("".next"").click(function () {

            current_fs = $(this).parent();
            next_fs = $(this).parent().next();

            //Add Class Active
            $(""#progressbar li"").eq($(""fieldset"").index(next_fs)).addClass(""active"");

            //show the next fieldset
            next_fs.show();
            //hide the current fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                       ");
            WriteLiteral(@" 'display': 'none',
                        'position': 'relative'
                    });
                    next_fs.css({ 'opacity': opacity });
                },
                duration: 600
            });
        });

        $("".previous"").click(function () {

            current_fs = $(this).parent();
            previous_fs = $(this).parent().prev();

            //Remove class active
            $(""#progressbar li"").eq($(""fieldset"").index(current_fs)).removeClass(""active"");

            //show the previous fieldset
            previous_fs.show();

            //hide the current fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                        'display': 'none',
                        'position': 'relative'
                    });
                    previous_fs.css({ '");
            WriteLiteral(@"opacity': opacity });
                },
                duration: 600
            });
        });

        $('.radio-group .radio').click(function () {
            $(this).parent().find('.radio').removeClass('selected');
            $(this).addClass('selected');
        });

        $("".submit"").click(function () {
            return false;
        })

    });</script>

<!-- MultiStep Form -->
<div class=""container"" id=""grad1"">
    <div class=""row justify-content-center mt-0"">
        <div class=""col-11 col-sm-9 col-md-12 col-lg-11 text-center p-0 mt-3 mb-2"">
            <div class=""card px-0 pt-4 pb-0 mt-3 mb-3"">
");
            WriteLiteral(@"                    <h2><strong>Yeni Ürün Ekle</strong></h2>
                    <p>Tüm bilgileri eksiksiz bir şekilde doldurup, ilerlemeye devam edin.Ürünüzün onaylanması yoğunluğa bağlı olarak 1-2 gün sürebilir.</p>
                    <div class=""row"">
                        <div class=""col-md-12 mx-0"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e239f1bd793a6a139ab599643cc8ed907c3b621319518", async() => {
                WriteLiteral("\r\n                                <!-- progressbar -->\r\n                                <ul id=\"progressbar\">\r\n                                    <input type=\"hidden\" name=\"MemberID\"");
                BeginWriteAttribute("value", " value =\"", 9832, "\"", 9858, 1);
#nullable restore
#line 335 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\AddProduct.cshtml"
WriteAttributeValue("", 9841, ViewBag.memberID, 9841, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                    
                                    <li class=""active"" id=""account""><strong>Kategori Seçimi</strong></li>
                                    <li id=""personal""><strong>Ürün Bilgileri</strong></li>
                                    <li id=""payment""><strong>Ürün Fotoğrafları</strong></li>
                                    <li id=""confirm""><strong>Bitiş</strong></li>
                                </ul> <!-- fieldsets -->
                                <fieldset>
                                    <div class=""form-card"">
                                        <p>Önce ürününümüzün kategorisini belirleyelim.</p>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Alt Kategori : </label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e239f1bd793a6a139ab599643cc8ed907c3b621321283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 347 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\AddProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.categoryList, "Value", "Text"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Üst Kategori : </label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e239f1bd793a6a139ab599643cc8ed907c3b621323435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 351 "C:\Users\ahmet\source\repos\eMarket\eMarket\eMarket.Web.UI\Views\Admin\AddProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(string.Empty, "Value", "Text"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>

                                    </div>
                                    <input type=""button"" name=""next"" class=""next action-button"" value=""İlerle"" />
                                </fieldset>
                                <fieldset>
                                    <div class=""form-card"">
                                        <p>Kategori belirledik,şimdi ürün bilgilerini dolduralım.</p> 
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Ad : </label>
                                            <input id=""cc-payment"" name=""Name"" type=""text"" class=""form-control"" aria-required=""true"" aria-invalid=""false"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Açıklama : </label");
                WriteLiteral(@">
                                            <input id=""cc-payment"" name=""Description"" type=""text"" class=""form-control"" aria-required=""true"" aria-invalid=""false"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Fiyat : </label>
                                            <input id=""Price"" name=""Price"" type=""text"" class=""form-control"" aria-required=""true"" aria-invalid=""false"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">Stok (Adet) : </label>
                                            <input id=""cc-payment"" name=""Stock"" type=""number"" class=""form-control"" aria-required=""true"" aria-invalid=""false"">
                                        </div>
                                    </d");
                WriteLiteral(@"iv>
                                    <input type=""button"" name=""previous"" class=""previous action-button-previous"" value=""Geri Dön"" /> <input type=""button"" name=""next"" class=""next action-button"" value=""İlerle"" />
                                </fieldset>
                                <fieldset>

                                    <div class=""form-card"">
                                        <p>Son olarak ürünümüzün için en az 1 en fazla 5 fotoğraf belirleyelim.Fotoğrafların net olmasına dikkat edelim.</p>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">1. Fotoğraf : </label>
                                            <input type=""file"" name=""files"" class=""form-control"" id=""files"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-lab");
                WriteLiteral(@"el mb-1"">2. Fotoğraf : </label>
                                            <input type=""file"" name=""files"" class=""form-control"" id=""files"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">3. Fotoğraf : </label>
                                            <input type=""file"" name=""files"" class=""form-control"" id=""files"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""control-label mb-1"">4. Fotoğraf : </label>
                                            <input type=""file"" name=""files"" class=""form-control"" id=""files"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""cc-payment"" class=""");
                WriteLiteral(@"control-label mb-1"">5. Fotoğraf : </label>
                                            <input type=""file"" name=""files"" class=""form-control"" id=""files"" />
                                        </div>

                                    </div>

                                    <p>Bilgilerinizi eksik doldurmadığınızdan eminseniz ürünüzü ekleyebilirsiniz.</p>
                                    <input type=""button"" name=""previous"" class=""previous action-button-previous"" value=""Geri Dön"" />
                                    <input type=""submit"" name=""make_payment"" class=""next action-button"" value=""Ürün Ekle"" />
                                </fieldset>
                                <fieldset>
                                    <div class=""form-card"">
                                        <h2 class=""fs-title text-center"">Success !</h2> <br><br>
                                        <div class=""row justify-content-center"">
                                            <div class=""col-3"">");
                WriteLiteral(@" <img src=""https://img.icons8.com/color/96/000000/ok--v2.png"" class=""fit-image""> </div>
                                        </div> <br><br>
                                        <div class=""row justify-content-center"">
                                            <div class=""col-7 text-center"">
                                                <h5>You Have Successfully Signed Up</h5>
                                            </div>
                                        </div>
                                    </div>
                                </fieldset>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>


<script>
    $(function () {
        $(""#ddlcountry"").change(function () {
            $.getJSON(""/Admin/GetSubCategory"",
                { CategoryID: $(""#ddlcountry"").val() },
                function (d) {
                    var row = """";
                    $(""#ddlstate"").empty();
                    $.each(d,
                        function (i, v) {
                            row += ""<option value="" + v.value + "">"" + v.text + ""</option>"";
                        });
                    $(""#ddlstate"").html(row);
                });
        });
    });
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eMarket.Entity.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591