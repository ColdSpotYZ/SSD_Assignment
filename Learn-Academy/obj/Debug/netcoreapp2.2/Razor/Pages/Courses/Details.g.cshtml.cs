#pragma checksum "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a4d94ac7fe27a7c6eb16240c71439602b81864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Learn_Academy.Pages.Courses.Pages_Courses_Details), @"mvc.1.0.razor-page", @"/Pages/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Courses/Details.cshtml", typeof(Learn_Academy.Pages.Courses.Pages_Courses_Details), null)]
namespace Learn_Academy.Pages.Courses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\_ViewImports.cshtml"
using Learn_Academy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a4d94ac7fe27a7c6eb16240c71439602b81864", @"/Pages/Courses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8088b3cfd981b9058f6f2fb4f213d18afff55823", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px;text-decoration:none;position:relative;top:10px;bottom:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Add-to-Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px;text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("styles", async() => {
                BeginContext(73, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 84, "\"", 121, 1);
#line 4 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
WriteAttributeValue("", 91, Url.Content("~/css/site.css"), 91, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(122, 38, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
                EndContext();
            }
            );
#line 6 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(1664, 34, true);
            WriteLiteral("\r\n<div class=\"custom-cart-button\">");
            EndContext();
            BeginContext(1698, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a4d94ac7fe27a7c6eb16240c71439602b818646035", async() => {
                BeginContext(1834, 25, true);
                WriteLiteral("<span>Back to List</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1863, 128, true);
            WriteLiteral("</div>\r\n\r\n<div style=\"background-color: #1E1E1C;min-height: 40vh;padding: 6%;\">\r\n    <div>\r\n\r\n        <h1 style=\"color: white;\">");
            EndContext();
            BeginContext(1992, 43, false);
#line 56 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 62, true);
            WriteLiteral("</h1>\r\n\r\n        <p><span style=\"color: white;\">Last updated: ");
            EndContext();
            BeginContext(2098, 49, false);
#line 58 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.Course.CourseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 52, true);
            WriteLiteral("</span></p>\r\n        <p><span style=\"color: white;\">");
            EndContext();
            BeginContext(2200, 45, false);
#line 59 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Course.Author));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 467, true);
            WriteLiteral(@"</span></p>
    </div>
    <div style=""background-color:white;position:absolute;width:420px;left:55%;top:20%;border: 1px solid black;text-align:center;padding-top:1%;"">
        <img src=""https://st.depositphotos.com/1364311/1336/i/950/depositphotos_13360079-stock-photo-girl-studying-in-library.jpg"" style=""width:400px;height:auto;"" alt=""Alternate Text"" />
        <div style=""padding:5%"">
            <span style=""color: #1E1E1C;text-decoration:line-through;"">$");
            EndContext();
            BeginContext(2713, 44, false);
#line 64 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Course.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 85, true);
            WriteLiteral("</span>\r\n            <span style=\"color: #1E1E1C;font-size:3rem;margin-left: 10px;\">$");
            EndContext();
            BeginContext(2843, 44, false);
#line 65 "C:\Users\jason\source\repos\SSD_Assignment\Learn-Academy\Pages\Courses\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Course.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 111, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"text-align:center;\">\r\n            <div class=\"custom-cart-button\">");
            EndContext();
            BeginContext(2998, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a4d94ac7fe27a7c6eb16240c71439602b8186410777", async() => {
                BeginContext(3088, 24, true);
                WriteLiteral("<span>Add To Cart</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3116, 149, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<section>\r\n    <div style=\"width:30vw;margin-left:10px;\">\r\n        <h2>Description</h2>\r\n        <h6>\r\n");
            EndContext();
            BeginContext(3335, 1097, true);
            WriteLiteral(@"            This course has been specifically designed for beginners who have been looking to obtain a hands-on learning experience with Python, teaching you concepts of programming right from the basics and Python being the most simplest language for a beginner to start with. <br /><br />

            It is the right time to start learning the in-demand Python language because of its gaining popularity in the fields on Data Science, Backend Development, Internet of Things, etc. Keep yourself equipped with the most sought-after skills! <br /><br />

            A lot of exercise problems, programming lectures, PDF notes have been included to provide you with a great learning experience! <br /><br />

            You will work on a project at the end of this course, which has been designed for you to implement all the topics which you would have mastered by the end of this course to give you enough confidence to start writing your own independent programs in Python. <br /><br />
        </h6>
    </div");
            WriteLiteral(">\r\n</section>\r\n<section>\r\n    <div>\r\n        <h2>Ratings & Reviews</h2>\r\n");
            EndContext();
            BeginContext(4515, 22, true);
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Learn_Academy.Pages.Courses.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.DetailsModel>)PageContext?.ViewData;
        public Learn_Academy.Pages.Courses.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
