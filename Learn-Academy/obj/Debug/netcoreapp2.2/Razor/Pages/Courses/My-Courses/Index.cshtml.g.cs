#pragma checksum "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397090b8bbdba4c59e06c519fd1221d23655cdd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Learn_Academy.Pages.Courses.My_Courses.Pages_Courses_My_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Courses/My-Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Courses/My-Courses/Index.cshtml", typeof(Learn_Academy.Pages.Courses.My_Courses.Pages_Courses_My_Courses_Index), null)]
namespace Learn_Academy.Pages.Courses.My_Courses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\_ViewImports.cshtml"
using Learn_Academy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397090b8bbdba4c59e06c519fd1221d23655cdd7", @"/Pages/Courses/My-Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8088b3cfd981b9058f6f2fb4f213d18afff55823", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_My_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(312, 586, true);
            WriteLiteral(@"
<h1>Index</h1>
<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
        width: 40%;
        max-width: 300px;
        max-height: 400px;
        min-width: 300px;
        max-height: 400px;
        margin-left: 10px;
    }

        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }

    .container {
        padding: 2px 16px;
    }

    .container-courses-wrap {
        text-align: center;
        width: 58vw;
        overflow: scroll;
        overflow-y: hidden;
    }
</style>
");
            EndContext();
#line 38 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(938, 49, true);
            WriteLiteral("    <div class=\"d-flex container-courses-wrap\">\r\n");
            EndContext();
#line 41 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
         foreach (var item in Model.Course)
        {
            

#line default
#line hidden
#line 43 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
             if (item.Author == User.Identity.Name)
            {

#line default
#line hidden
            BeginContext(1111, 290, true);
            WriteLiteral(@"                <div class=""card"">
                    <img src=""https://st.depositphotos.com/1364311/1336/i/950/depositphotos_13360079-stock-photo-girl-studying-in-library.jpg"" alt=""Avatar"" style=""width: 100%"">
                    <div class=""container"">
                        <h4><b>");
            EndContext();
            BeginContext(1402, 39, false);
#line 48 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 76, true);
            WriteLiteral("</b></h4>\r\n                        <p style=\"text-decoration:line-through;\">");
            EndContext();
            BeginContext(1518, 40, false);
#line 49 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 120, true);
            WriteLiteral("</p>\r\n                        <!-- Change this to updated price -->\r\n                        <p style=\"font-size: 2em;\">");
            EndContext();
            BeginContext(1679, 40, false);
#line 51 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 52 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                         if (signInManager.IsSignedIn(User) && (User.IsInRole("Teacher") || User.IsInRole("Admin")))
                        {

#line default
#line hidden
            BeginContext(1870, 67, true);
            WriteLiteral("                            <div>\r\n                                ");
            EndContext();
            BeginContext(1937, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397090b8bbdba4c59e06c519fd1221d23655cdd78064", async() => {
                BeginContext(1983, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                                                        WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1991, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2027, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397090b8bbdba4c59e06c519fd1221d23655cdd710455", async() => {
                BeginContext(2076, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2087, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2123, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397090b8bbdba4c59e06c519fd1221d23655cdd712853", async() => {
                BeginContext(2171, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2181, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 59 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2246, 56, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 64 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
            }

#line default
#line hidden
#line 64 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
             

        }

#line default
#line hidden
            BeginContext(2330, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 69 "C:\Users\limka\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<Learn_Academy.Models.ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Learn_Academy.Pages.Courses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.IndexModel>)PageContext?.ViewData;
        public Learn_Academy.Pages.Courses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
