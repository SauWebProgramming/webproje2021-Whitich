#pragma checksum "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9a63cd561bad3b35d032e0124d72da20d7f4c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
#line 1 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\_ViewImports.cshtml"
using WebProgramlama;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\_ViewImports.cshtml"
using WebProgramlama.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9a63cd561bad3b35d032e0124d72da20d7f4c9", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6250cdc28fff796181e9290b82befd9e8a811163", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/_BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div style=\"width:auto; margin:auto; margin-top:4%;\">\r\n\r\n            <h4 style=\" text-align:center;  color:black;\"> ");
#nullable restore
#line 12 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"
                                                      Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n\r\n        </div>\r\n");
            WriteLiteral("    <div style=\"max-width: 75%; height: auto; margin: auto; margin-top: 4%; \">\r\n\r\n        <div class=\"post-content-body\" >\r\n\r\n            \r\n            <div style=\" width: ; margin: auto; margin-bottom: 5%;\">\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 584, "\"", 605, 1);
#nullable restore
#line 24 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 590, item.BlogImage, 590, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image placeholder\" class=\"img-fluid rounded\" style=\"width: auto; display: block; margin: auto;  \" >\r\n\r\n           </div>\r\n\r\n\r\n           \r\n            <p>");
#nullable restore
#line 30 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"
          Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\merth\source\repos\WebProgramlama\WebProgramlama\Views\Blog\BlogDetails.cshtml"

    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591