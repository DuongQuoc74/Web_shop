#pragma checksum "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30939f1f1b0fa50c74c21038b09df5003e46798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
#line 1 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30939f1f1b0fa50c74c21038b09df5003e46798", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5978f5a349a5eea6eac34820a34a3ca20251bf65", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal span6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
  
    ViewData["Title"] = Model.Category.Name + (Model.Product.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Product.PageIndex);
    ViewData["Description"] = Model.Category.Name + (Model.Product.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Product.PageIndex);
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"breadcrumb\">\r\n    <li><a href=\"index.html\">Home</a> <span class=\"divider\">/</span></li>\r\n    <li class=\"active\">Products Name</li>\r\n</ul>\r\n<h3> ");
#nullable restore
#line 16 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"pull-right\"> 40 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e467985807", async() => {
                WriteLiteral("available products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </small></h3>\r\n<hr class=\"soft\" />\r\n<p>\r\n    Mô tả của ứng dụng (hard)\r\n</p>\r\n<hr class=\"soft\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e467986906", async() => {
                WriteLiteral("\r\n    <div class=\"control-group\">\r\n        <label class=\"control-label alignL\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e467987247", async() => {
                    WriteLiteral("Sort By");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </label>\r\n        <select>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e467988320", async() => {
                    WriteLiteral("Priduct name A - Z");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e467989358", async() => {
                    WriteLiteral("Priduct name Z - A");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679810396", async() => {
                    WriteLiteral("Priduct Stoke");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679811430", async() => {
                    WriteLiteral("Price Lowest first");
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
                WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
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

<div id=""myTab"" class=""pull-right"">
    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
</div>
<br class=""clr"" />
<div class=""tab-content"">
    <div class=""tab-pane"" id=""listView"">
");
#nullable restore
#line 41 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
         for (int i = 0; i < Model.Product.items.Count; i++)
        {
            var item = Model.Product.items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"span2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1929, "\"", 1991, 2);
#nullable restore
#line 46 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1935, _configuration["BaseAddress"] + @item.ThumbnailImage, 1935, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1990, "", 1991, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1992, "\"", 2008, 1);
#nullable restore
#line 46 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1998, item.Name, 1998, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"span4\">\r\n                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679815300", async() => {
                WriteLiteral("New | Available");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                    <hr class=\"soft\" />\r\n                    <h5>");
#nullable restore
#line 51 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>\r\n                        ");
#nullable restore
#line 53 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <a class=\"btn btn-small pull-right\" href=\"product_details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679817040", async() => {
                WriteLiteral("Xem chi tiết");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    <br class=\"clr\" />\r\n                </div>\r\n                <div class=\"span3 alignR\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679818164", async() => {
                WriteLiteral("\r\n                        <h3> ");
#nullable restore
#line 60 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                        Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                        <label class=""checkbox"">
                            <input type=""checkbox"">  Adds product to compair
                        </label><br />

                        <a href=""product_details.html"" class=""btn btn-large btn-primary""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679819008", async() => {
                    WriteLiteral("Add to");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <i class=\" icon-shopping-cart\"></i></a>\r\n                        <a href=\"product_details.html\" class=\"btn btn-large\"><i class=\"icon-zoom-in\"></i></a>\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr class=\"soft\" />\r\n");
#nullable restore
#line 71 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"tab-pane  active\" id=\"blockView\">\r\n        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 76 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
             for (int i = 0; i < Model.Product.items.Count; i++)
            {
                var item = Model.Product.items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"span3\">\r\n                    <div class=\"thumbnail\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3573, "\"", 3621, 6);
            WriteAttributeValue("", 3580, "/", 3580, 1, true);
#nullable restore
#line 81 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3581, culture.Name, 3581, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3594, "/", 3594, 1, true);
#nullable restore
#line 81 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3595, _loc["products"], 3595, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3612, "/", 3612, 1, true);
#nullable restore
#line 81 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3613, item.Id, 3613, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3627, "\"", 3688, 1);
#nullable restore
#line 81 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3633, _configuration["BaseAddress"] + @item.ThumbnailImage, 3633, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3689, "\"", 3705, 1);
#nullable restore
#line 81 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3695, item.Name, 3695, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <div class=\"caption\">\r\n                            <h5>");
#nullable restore
#line 83 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                                ");
#nullable restore
#line 85 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <h4 style=""text-align:center"">
                                <a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a>
                                <a class=""btn"" href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30939f1f1b0fa50c74c21038b09df5003e4679824935", async() => {
                WriteLiteral("Add to");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                                <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 90 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
                                                               Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h4>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 95 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <hr class=\"soft\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 100 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Product\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br class=\"clr\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
