#pragma checksum "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c737adca5b2ae02d22b0e8f813f61a73daee5cba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Learn_Academy.Pages.Courses.Ratings.Pages_Courses_Ratings_Details), @"mvc.1.0.razor-page", @"/Pages/Courses/Ratings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Courses/Ratings/Details.cshtml", typeof(Learn_Academy.Pages.Courses.Ratings.Pages_Courses_Ratings_Details), null)]
namespace Learn_Academy.Pages.Courses.Ratings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\_ViewImports.cshtml"
using Learn_Academy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c737adca5b2ae02d22b0e8f813f61a73daee5cba", @"/Pages/Courses/Ratings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8088b3cfd981b9058f6f2fb4f213d18afff55823", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_Ratings_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(156, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Rating</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(284, 51, false);
#line 16 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.CourseID));

#line default
#line hidden
            EndContext();
            BeginContext(335, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(397, 47, false);
#line 19 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.CourseID));

#line default
#line hidden
            EndContext();
            BeginContext(444, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(505, 55, false);
#line 22 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(560, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(622, 51, false);
#line 25 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(673, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(734, 55, false);
#line 28 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.CourseRating));

#line default
#line hidden
            EndContext();
            BeginContext(789, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(851, 51, false);
#line 31 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.CourseRating));

#line default
#line hidden
            EndContext();
            BeginContext(902, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(963, 50, false);
#line 34 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1075, 46, false);
#line 37 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1182, 47, false);
#line 40 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1291, 43, false);
#line 43 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1395, 53, false);
#line 46 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.CourseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1510, 49, false);
#line 49 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.CourseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1620, 51, false);
#line 52 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1733, 47, false);
#line 55 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1841, 49, false);
#line 58 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1952, 45, false);
#line 61 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2044, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c737adca5b2ae02d22b0e8f813f61a73daee5cba11354", async() => {
                BeginContext(2097, 4, true);
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
#line 66 "C:\Users\darie\Source\Repos\SSD_Assignment\Learn-Academy\Pages\Courses\Ratings\Details.cshtml"
                           WriteLiteral(Model.Rating.ID);

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
            BeginContext(2105, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2113, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c737adca5b2ae02d22b0e8f813f61a73daee5cba13695", async() => {
                BeginContext(2135, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2151, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Learn_Academy.Pages.Courses.Ratings.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.Ratings.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.Ratings.DetailsModel>)PageContext?.ViewData;
        public Learn_Academy.Pages.Courses.Ratings.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
