#pragma checksum "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072554be3dea3753d5d9dcd1380f751ee7c306fd"
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
#line 1 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\_ViewImports.cshtml"
using Learn_Academy;

#line default
#line hidden
#line 4 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
using Learn_Academy.Models;

#line default
#line hidden
#line 5 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072554be3dea3753d5d9dcd1380f751ee7c306fd", @"/Pages/Courses/My-Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8088b3cfd981b9058f6f2fb4f213d18afff55823", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_My_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Courses/Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(377, 586, true);
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
#line 40 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(1003, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1007, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "072554be3dea3753d5d9dcd1380f751ee7c306fd7192", async() => {
                BeginContext(1031, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1045, 51, true);
            WriteLiteral("\r\n    <div class=\"d-flex container-courses-wrap\">\r\n");
            EndContext();
#line 44 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
         foreach (var item in (List<Course>)ViewData["Course"])
        {
            

#line default
#line hidden
#line 46 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
             if (item.Author == User.Identity.Name)
            {

#line default
#line hidden
            BeginContext(1240, 56, true);
            WriteLiteral("                <div class=\"card\">\r\n                    ");
            EndContext();
            BeginContext(1296, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "072554be3dea3753d5d9dcd1380f751ee7c306fd9338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1306, "~/uploads/image/", 1306, 16, true);
#line 49 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
AddHtmlAttributeValue("", 1322, Html.Raw(item.image), 1322, 21, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1382, 78, true);
            WriteLiteral("\r\n                    <div class=\"container\">\r\n                        <h4><b>");
            EndContext();
            BeginContext(1461, 39, false);
#line 51 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 11, true);
            WriteLiteral("</b></h4>\r\n");
            EndContext();
#line 52 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                         if (signInManager.IsSignedIn(User) && (User.IsInRole("Teacher") || User.IsInRole("Admin")))
                        {

#line default
#line hidden
            BeginContext(1656, 67, true);
            WriteLiteral("                            <div>\r\n                                ");
            EndContext();
            BeginContext(1723, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "072554be3dea3753d5d9dcd1380f751ee7c306fd12234", async() => {
                BeginContext(1769, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
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
            BeginContext(1777, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(1813, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "072554be3dea3753d5d9dcd1380f751ee7c306fd14687", async() => {
                BeginContext(1862, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
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
            BeginContext(1873, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 58 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1938, 56, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 63 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
            }

#line default
#line hidden
#line 63 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
             

        }

#line default
#line hidden
            BeginContext(2022, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 68 "C:\Users\limka\OneDrive\Documents\Ngee Ann Poly\Year 2 Sem 1\Secure Software Development\SSD_Assignment\Learn-Academy\Pages\Courses\My-Courses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2039, 41, true);
            WriteLiteral("<div>\r\n    To edit and add videos, <span>");
            EndContext();
            BeginContext(2080, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "072554be3dea3753d5d9dcd1380f751ee7c306fd18447", async() => {
                BeginContext(2110, 10, true);
                WriteLiteral("Click here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(2124, 15, true);
            WriteLiteral("</span>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Learn_Academy.Pages.Courses.My_Courses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.My_Courses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Learn_Academy.Pages.Courses.My_Courses.IndexModel>)PageContext?.ViewData;
        public Learn_Academy.Pages.Courses.My_Courses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
