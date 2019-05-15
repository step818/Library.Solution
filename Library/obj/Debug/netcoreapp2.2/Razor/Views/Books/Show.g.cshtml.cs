#pragma checksum "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00392a4e7655018ffdb54059d86ffcd40d192ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Show), @"mvc.1.0.view", @"/Views/Books/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Show.cshtml", typeof(AspNetCore.Views_Books_Show))]
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
#line 1 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00392a4e7655018ffdb54059d86ffcd40d192ad", @"/Views/Books/Show.cshtml")]
    public class Views_Books_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 28, true);
            WriteLiteral("\n<h1>Library</h1>\n<h2>Book: ");
            EndContext();
            BeginContext(52, 32, false);
#line 4 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
     Write(Model["selectedBook"].GetTitle());

#line default
#line hidden
            EndContext();
            BeginContext(84, 14, true);
            WriteLiteral("</h2>\n<hr />\n\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
 if (@Model["bookAuthors"].Count != 0)
{

#line default
#line hidden
            BeginContext(139, 47, true);
            WriteLiteral("  <h4>This book has these authors:</h4>\n  <ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
     foreach (Author author in @Model["bookAuthors"])
    {

#line default
#line hidden
            BeginContext(246, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(257, 16, false);
#line 13 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
     Write(author.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(273, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(285, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
}

#line default
#line hidden
            BeginContext(295, 44, true);
            WriteLiteral("\n<h4>Add an author to this book:</h4>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 339, "\'", 400, 3);
            WriteAttributeValue("", 348, "/books/", 348, 7, true);
#line 20 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
WriteAttributeValue("", 355, Model["selectedBook"].GetId(), 355, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 385, "/categories/new", 385, 15, true);
            EndWriteAttribute();
            BeginContext(401, 118, true);
            WriteLiteral(" method=\'post\'>\n  <label for=\'authorId\'>Select an author</label>\n  <select id=\'authorId\' name=\'authorId\' type=\'text\'>\n");
            EndContext();
#line 23 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
     foreach (var author in @Model["allAuthors"])
    {

#line default
#line hidden
            BeginContext(575, 13, true);
            WriteLiteral("      <option");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 588, "\'", 611, 1);
#line 25 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
WriteAttributeValue("", 596, author.GetId(), 596, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(614, 16, false);
#line 25 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
                                 Write(author.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(630, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 26 "/Users/Guest/Desktop/Library-Solution/Library/Views/Books/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(646, 101, true);
            WriteLiteral("  </select>\n  <button type=\'submit\'>Add</button>\n</form>\n\n<p><a href=\"/\">Return to Main Page</a></p>\n");
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
