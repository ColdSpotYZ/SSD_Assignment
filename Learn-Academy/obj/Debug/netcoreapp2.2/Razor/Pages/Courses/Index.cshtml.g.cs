#pragma checksum "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35d9007bbf306fceb7ed528475668e70f1d318a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Learn_Academy.Pages.Courses.Pages_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Courses/Index.cshtml", typeof(Learn_Academy.Pages.Courses.Pages_Courses_Index), null)]
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
#line 1 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\_ViewImports.cshtml"
using Learn_Academy;

#line default
#line hidden
#line 3 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
using Learn_Academy.Models;

#line default
#line hidden
#line 4 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35d9007bbf306fceb7ed528475668e70f1d318a", @"/Pages/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8088b3cfd981b9058f6f2fb4f213d18afff55823", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                BeginContext(252, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 265, "\"", 328, 1);
#line 8 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
WriteAttributeValue("", 271, Url.Content("https://kit.fontawesome.com/9c3fdd9015.js"), 271, 57, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(329, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 352, "\"", 439, 1);
#line 9 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
WriteAttributeValue("", 358, Url.Content("https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"), 358, 81, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(440, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 463, "\"", 567, 1);
#line 10 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
WriteAttributeValue("", 469, Url.Content("https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.1/js/bootstrap.min.js"), 469, 98, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(568, 16, true);
                WriteLiteral("></script>\r\n\r\n\r\n");
                EndContext();
            }
            );
#line 14 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(628, 2521, true);
            WriteLiteral(@"<style>
    .body {
        overflow-x: hidden;
    }

    .custom-wrap-details {
        justify-content: space-around;
        color: white;
        margin-top: 10px;
    }

        .custom-wrap-details h2 {
            font-size: 20px;
        }

    .draft-container-wrap {
        margin-bottom: 10vh;
        display: block;
    }

    .draft-container {
        position: relative;
        display: inline-block;
    }

    .draft-image {
        width: 98vw;
        min-height: 200px;
    }

    .draft-text {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate( -50%, -50% );
        color: white;
    }

        .draft-text h1, .draft-text h3 {
            font-family: 'Poppins', sans-serif;
            font-weight: 700;
            text-align: center;
            text-shadow: -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000, 1px 1px 0 #000;
        }

        .draft-text h1 {
            font-size: 5rem;
        }
");
            WriteLiteral(@"
    .custom-search-bar {
        min-width: 45vw;
    }

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

    /* Become a teacher */


    .custom-teacher-wrap {
        background-color: #d6edf6;
        margin: 10vh 0;
    }

    .custom-teacher-text {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-content: center;
    }
</style>

<div id=""banner"" class=""draft-container-wrap"">
    <div class=""draft-container"">
        <img class=""draft-i");
            WriteLiteral(@"mage img-fluid"" src=""https://images.unsplash.com/photo-1485546246426-74dc88dec4d9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80"" alt=""Experience"" />
        <div class=""draft-text"">
            <div class=""custom-wrap-Titles"">
                <h1 style=""font-size: 40px;"">
                    The World's Best Online Learning Platform <br />
                    Only at Learn Academy
                </h1>
            </div>
            ");
            EndContext();
            BeginContext(3149, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35d9007bbf306fceb7ed528475668e70f1d318a11345", async() => {
                BeginContext(3168, 83, true);
                WriteLiteral("\r\n                <div class=\"input-group custom-search-bar\">\r\n                    ");
                EndContext();
                BeginContext(3251, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a35d9007bbf306fceb7ed528475668e70f1d318a11815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 124 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.searchCourses);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3329, 229, true);
                WriteLiteral("\r\n                    <div class=\"input-group-append\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-search\"></i></button>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3565, 399, true);
            WriteLiteral(@"
            <div class=""d-flex custom-wrap-details"">
                <h2 style=""color:yellow;"">More than 10,000 Courses</h2>
                <h2 style=""color:turquoise;"">Over 300,000 Students</h2>
                <h2 style=""color:red;"">Start Learning Now</h2>
            </div>
        </div>
    </div>
</div>
<h1>Courses that we offer</h1>
<div class=""d-flex container-courses-wrap"">
");
            EndContext();
#line 140 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
     foreach (var item in Model.Course)
    {
        if (item.video != null)
        {

#line default
#line hidden
            BeginContext(4056, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(4068, 826, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35d9007bbf306fceb7ed528475668e70f1d318a15979", async() => {
                BeginContext(4158, 38, true);
                WriteLiteral("\r\n                <div class=\"card\">\r\n");
                EndContext();
                BeginContext(4356, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(4376, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a35d9007bbf306fceb7ed528475668e70f1d318a16534", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4386, "~/uploads/image/", 4386, 16, true);
#line 147 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
AddHtmlAttributeValue("", 4402, Html.Raw(item.image), 4402, 21, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4458, 78, true);
                WriteLiteral("\r\n                    <div class=\"container\">\r\n                        <h4><b>");
                EndContext();
                BeginContext(4537, 39, false);
#line 149 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4576, 38, true);
                WriteLiteral("</b></h4>\r\n                        <p>");
                EndContext();
                BeginContext(4615, 41, false);
#line 150 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
                EndContext();
                BeginContext(4656, 120, true);
                WriteLiteral("</p>\r\n                        <!-- Change this to updated price -->\r\n                        <p style=\"font-size: 2em;\">");
                EndContext();
                BeginContext(4777, 43, false);
#line 152 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
                EndContext();
                BeginContext(4820, 70, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 144 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
                                      WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4894, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 156 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(4914, 712, true);
            WriteLiteral(@"</div>

<div class=""row custom-teacher-wrap"">
    <div class=""col-md-6"">
        <div>
            <img style=""max-width: 500px; position: relative; bottom: 30px;left:20px"" src=""https://images.unsplash.com/photo-1472162072942-cd5147eb3902?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80"" alt=""Avatar"">
        </div>
    </div>
    <div class=""col-md-6"" style=""display: flex; align-content: center;"">
        <div class=""text-center custom-teacher-text"">
            <h3>Like our courses?</h3>
            <p>Give us a testimonial so that other students can be as happy as you!</p>
            <a href=""/Testimonial""><b>Click here</b></a>
        </div>
    </div>
</div>");
            EndContext();
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
