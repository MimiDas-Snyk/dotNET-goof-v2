#pragma checksum "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08025d60424e7f300e0f98ffc49768a44d0558dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotNETGoofV2.Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace dotNETGoofV2.Website.Pages
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
#line 1 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/_ViewImports.cshtml"
using dotNETGoofV2.Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08025d60424e7f300e0f98ffc49768a44d0558dd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7794349c44d4d4a063a2847e83064efb9ed631", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">dotNET Goof V2</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n<div class=\"card-columns\">\n\n");
#nullable restore
#line 14 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 391, "\"", 439, 4);
            WriteAttributeValue("", 399, "background-image:", 399, 17, true);
            WriteAttributeValue(" ", 416, "url(\'", 417, 6, true);
#nullable restore
#line 17 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml"
WriteAttributeValue("", 422, product.Image, 422, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, "\');", 436, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 19 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml"
                              Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n        \n    </div>\n");
#nullable restore
#line 23 "/Users/mattbrown/Desktop/SME_Work/dotNETGoofV2/dotNETGoofV2.Website/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591