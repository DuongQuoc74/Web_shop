#pragma checksum "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d313cb1095c0c49cad434f9c325ecab1e1fde67e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\_ViewImports.cshtml"
using eShopsolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\_ViewImports.cshtml"
using eShopsolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d313cb1095c0c49cad434f9c325ecab1e1fde67e", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5978f5a349a5eea6eac34820a34a3ca20251bf65", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li><a href=\"index.html\">Home</a> <span class=\"divider\">/</span></li>\r\n");
            WriteLiteral("    <li class=\"active\">");
#nullable restore
#line 15 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n<div class=\"row\">\r\n    <div id=\"gallery\" class=\"span3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 766, 1);
#nullable restore
#line 19 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 705, _configuration["BaseAddress"]+Model.Product.ThumbnailImage, 705, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 767, "\"", 794, 1);
#nullable restore
#line 19 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 775, Model.Product.Name, 775, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 814, "\"", 881, 1);
#nullable restore
#line 20 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 820, _configuration["BaseAddress"]+Model.Product.ThumbnailImage, 820, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 901, "\"", 926, 1);
#nullable restore
#line 20 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 907, Model.Product.Name, 907, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </a>
        <div id=""differentview"" class=""moreOptopm carousel slide"">
            <div class=""carousel-inner"">
                <div class=""item active"">
                    <a href=""themes/images/products/large/f1.jpg""> <img style=""width:29%"" src=""themes/images/products/large/f1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1230, "\"", 1236, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1377, "\"", 1383, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1524, "\"", 1530, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </div>\r\n                <div class=\"item\">\r\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1731, "\"", 1737, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f1.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1878, "\"", 1884, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2025, "\"", 2031, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                </div>
            </div>
            <!--
            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">‹</a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">›</a>
            -->
        </div>

        <div class=""btn-toolbar"">
            <div class=""btn-group"">
                <span class=""btn""><i class=""icon-envelope""></i></span>
                <span class=""btn""><i class=""icon-print""></i></span>
                <span class=""btn""><i class=""icon-zoom-in""></i></span>
                <span class=""btn""><i class=""icon-star""></i></span>
                <span class=""btn""><i class="" icon-thumbs-up""></i></span>
                <span class=""btn""><i class=""icon-thumbs-down""></i></span>
            </div>
        </div>
    </div>
    <div class=""span6"">
        <h3>");
#nullable restore
#line 53 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <small>");
#nullable restore
#line 54 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
          Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        <hr class=\"soft\" />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e10538", async() => {
                WriteLiteral("\r\n            <div class=\"control-group\">\r\n                <label class=\"control-label\"><span>");
#nullable restore
#line 58 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
                                              Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></label>
                <div class=""controls"">
                    <input type=""number"" class=""span1"" placeholder=""Qty."" />
                    <button type=""submit"" class=""btn btn-large btn-primary pull-right""> Add to cart <i class="" icon-shopping-cart""></i></button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <hr class=\"soft\" />\r\n        <h4>100 items in stock</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e12669", async() => {
                WriteLiteral("\r\n            <div class=\"control-group\">\r\n                <label class=\"control-label\"><span>Color</span></label>\r\n                <div class=\"controls\">\r\n                    <select class=\"span2\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e13166", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e14204", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e15240", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e16277", async() => {
                    WriteLiteral("Brown");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr class=\"soft clr\" />\r\n        <p>\r\n            ");
#nullable restore
#line 83 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
       Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </p>
        <a class=""btn btn-small pull-right"" href=""#detail"">More Details</a>
        <br class=""clr"" />
        <a href=""#"" name=""detail""></a>
        <hr class=""soft"" />
    </div>

    <div class=""span9"">
        <ul id=""productDetail"" class=""nav nav-tabs"">
            <li class=""active""><a href=""#home"" data-toggle=""tab"">Product Details</a></li>
            <li><a href=""#profile"" data-toggle=""tab"">Related Products</a></li>
        </ul>
        <div id=""myTabContent"" class=""tab-content"">
            <div class=""tab-pane fade active in"" id=""home"">
                <h4>Product Information</h4>
                ");
#nullable restore
#line 100 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Detail.cshtml"
           Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""tab-pane fade"" id=""profile"">
                <div id=""myTab"" class=""pull-right"">
                    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
                    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
                </div>
                <br class=""clr"" />
                <hr class=""soft"" />
                <div class=""tab-content"">
                    <div class=""tab-pane"" id=""listView"">
                        <div class=""row"">
                            <div class=""span2"">
                                <img src=""themes/images/products/4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5639, "\"", 5645, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            </div>
                            <div class=""span4"">
                                <h3>New | Available</h3>
                                <hr class=""soft"" />
                                <h5>Product Name </h5>
                                <p>
                                    Nowadays the lingerie industry is one of the most successful business spheres.We always stay in touch with the latest fashion tendencies -
                                    that is why our goods are so popular..
                                </p>
                                <a class=""btn btn-small pull-right"" href=""product_details.html"">View Details</a>
                                <br class=""clr"" />
                            </div>
                            <div class=""span3 alignR"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d313cb1095c0c49cad434f9c325ecab1e1fde67e21520", async() => {
                WriteLiteral(@"
                                    <h3> $222.00</h3>
                                    <label class=""checkbox"">
                                        <input type=""checkbox"">  Adds product to compair
                                    </label><br />
                                    <div class=""btn-group"">
                                        <a href=""product_details.html"" class=""btn btn-large btn-primary""> Add to <i class="" icon-shopping-cart""></i></a>
                                        <a href=""product_details.html"" class=""btn btn-large""><i class=""icon-zoom-in""></i></a>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                        <hr class=""soft"" />
                        
                    </div>
                    <div class=""tab-pane active"" id=""blockView"">
                        <ul class=""thumbnails"">
                            <li class=""span3"">
                                <div class=""thumbnail"">
                                    <a href=""product_details.html""><img src=""themes/images/products/10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7739, "\"", 7745, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                    <div class=""caption"">
                                        <h5>Manicure &amp; Pedicure</h5>
                                        <p>
                                            Lorem Ipsum is simply dummy text.
                                        </p>
                                        <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">&euro;222.00</a></h4>
                                    </div>
                                </div>
                            </li>
                            
                        </ul>
                        <hr class=""soft"" />
                    </div>
                </div>
                <br class=""clr"">
            </div>
        </div>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration _configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
