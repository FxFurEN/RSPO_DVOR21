#pragma checksum "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b3787fb31c4a314629c0929a83289fa971c2ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
#line 1 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\_ViewImports.cshtml"
using BeautyBooking.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\_ViewImports.cshtml"
using BeautyBooking.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b3787fb31c4a314629c0929a83289fa971c2ac", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9061ceacb3f8e30506ec034bed1cdd1c222cf1d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeautyBooking.Web.ViewModels.Categories.CategoriesListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
  
    this.ViewData["Title"] = "Categories of Beauty Services";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <!-- News Posts -->\n");
#nullable restore
#line 9 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\n            <hr class=\"bg-dark mx-4\" style=\"height: 6px;\" />\n            <!-- News Post -->\n            <div class=\"news_post\">\n                <div class=\"news_post_image\"><img");
            BeginWriteAttribute("src", " src=\"", 444, "\"", 468, 1);
#nullable restore
#line (15,56)-(15,74) 29 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
WriteAttributeValue("", 450, category.ImageUrl, 450, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 469, "\"", 475, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <div class=\"news_post_content\">\n                    <div class=\"news_post_title text-center\"><a>");
#nullable restore
#line (17,66)-(17,79) 6 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\n                    <div class=\"news_post_text\">\n                        <p>");
#nullable restore
#line (19,29)-(19,49) 6 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""text-center"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""about_text_highlight"">
                                Book an appointment in 3 easy steps:
                            </div>
                            <div class=""about_text_2"">
                                <ul>
                                    <li>1. Find a salon.</li>
                                    <li>2. Choose a beauty service.</li>
                                    <li>3. Pick date and time.</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""button button-large button_1 elements_button mt-4"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1b3787fb31c4a314629c0929a83289fa971c2ac7057", async() => {
                WriteLiteral("\n                                    <span>Find Salons</span>\n                                    <span>Find Salons</span>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (40,110)-(40,121) 13 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 50 "C:\3 курс\рспо\сдал\RSPO_DVOR21\Web\BeautyBooking.Web\Views\Categories\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeautyBooking.Web.ViewModels.Categories.CategoriesListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
