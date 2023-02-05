#pragma checksum "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7175202c9723794b4a46d674cf476cd55f1db214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7175202c9723794b4a46d674cf476cd55f1db214", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5978f5a349a5eea6eac34820a34a3ca20251bf65", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Common.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex -5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount >1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 31 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 941, "\"", 980, 1);
#nullable restore
#line 34 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 948, urlTemplate.Replace("{0}", "1"), 948, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1148, 1);
#nullable restore
#line 37 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1089, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1089, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 39 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 47 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1587, "\"", 1614, 2);
            WriteAttributeValue("", 1595, "Trang", 1595, 5, true);
#nullable restore
#line 50 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1600, i.ToString(), 1601, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1615, "\"", 1663, 1);
#nullable restore
#line 50 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1622, urlTemplate.Replace("{0}", i.ToString()), 1622, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1833, "\"", 1868, 1);
#nullable restore
#line 56 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1841, Model.PageCount.ToString(), 1841, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1935, 1);
#nullable restore
#line 56 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1876, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1876, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2037, "\"", 2099, 1);
#nullable restore
#line 59 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2044, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2044, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 61 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 63 "D:\Data\Homes\File.Net\Projects\eShopsolution\eShopsolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Common.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
