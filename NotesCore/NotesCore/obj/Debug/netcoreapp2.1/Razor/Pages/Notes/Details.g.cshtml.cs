#pragma checksum "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbd053fb77502847bf642cb73dbad69b27e87ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Notes_Details), @"mvc.1.0.razor-page", @"/Pages/Notes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Notes/Details.cshtml", typeof(AspNetCore.Pages_Notes_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dbd053fb77502847bf642cb73dbad69b27e87ee", @"/Pages/Notes/Details.cshtml")]
    public class Pages_Notes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Note</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 47, false);
#line 15 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Note.Author));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 43, false);
#line 18 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Note.Author));

#line default
#line hidden
            EndContext();
            BeginContext(348, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(392, 46, false);
#line 21 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Note.Value));

#line default
#line hidden
            EndContext();
            BeginContext(438, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(482, 42, false);
#line 24 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Note.Value));

#line default
#line hidden
            EndContext();
            BeginContext(524, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 591, "\"", 620, 1);
#line 29 "C:\Users\Mateeusz\dotnet-notes\NotesCore\NotesCore\Pages\Notes\Details.cshtml"
WriteAttributeValue("", 606, Model.Note.Id, 606, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(621, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotesCore.Pages.Notes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotesCore.Pages.Notes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotesCore.Pages.Notes.DetailsModel>)PageContext?.ViewData;
        public NotesCore.Pages.Notes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591