#pragma checksum "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebe9275e6ee8ec765b1c32ecf8962ea461be7ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(net_on_the_web.Pages.Pages_HelloWeb), @"mvc.1.0.razor-page", @"/Pages/HelloWeb.cshtml")]
namespace net_on_the_web.Pages
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
#line 1 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/_ViewImports.cshtml"
using net_on_the_web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe9275e6ee8ec765b1c32ecf8962ea461be7ed1", @"/Pages/HelloWeb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693f33b5265dd69f077750d8fba0d550d4a36ebd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HelloWeb : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <thead>Student Id</thead>\r\n        <thead>Student Name</thead>\r\n        <thead>Student ClassId</thead>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Peter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Peter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Peter.ClassId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 18 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Thomas.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Thomas.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Thomas.ClassId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 23 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Micha.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Micha.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "/home/peter/Documents/Projects/dotnet/net-on-the-web/Pages/HelloWeb.cshtml"
       Write(Model.Micha.ClassId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<net_on_the_web.Pages.HelloWebModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<net_on_the_web.Pages.HelloWebModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<net_on_the_web.Pages.HelloWebModel>)PageContext?.ViewData;
        public net_on_the_web.Pages.HelloWebModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
