#pragma checksum "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b520ee1b2660f5c42bc804596378d479288fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Show), @"mvc.1.0.view", @"/Views/Items/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Show.cshtml", typeof(AspNetCore.Views_Items_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b520ee1b2660f5c42bc804596378d479288fd0", @"/Views/Items/Show.cshtml")]
    public class Views_Items_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 44, true);
            WriteLiteral("\r\n<h1>To Do List Item Details: </h1>\r\n\r\n<h2>");
            EndContext();
            BeginContext(75, 25, false);
#line 7 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\Show.cshtml"
Write(Model["item"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(100, 21, true);
            WriteLiteral("</h2>\r\n<h3>Category: ");
            EndContext();
            BeginContext(122, 22, false);
#line 8 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\Show.cshtml"
         Write(Model["category"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 11, true);
            WriteLiteral("</h3>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 155, "\'", 213, 3);
            WriteAttributeValue("", 162, "/categories/", 162, 12, true);
#line 10 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\Show.cshtml"
WriteAttributeValue("", 174, Model["category"].CategoryId, 174, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 203, "/items/new", 203, 10, true);
            EndWriteAttribute();
            BeginContext(214, 68, true);
            WriteLiteral(">Add another item</a>\r\n<a href=\'/categories\'>View all categories</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591