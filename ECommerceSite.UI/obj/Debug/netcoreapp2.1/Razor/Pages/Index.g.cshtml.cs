#pragma checksum "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3431d043d7d333837d98f167d5bf50c0fafaff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECommerceSite.UI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(ECommerceSite.UI.Pages.Pages_Index), null)]
namespace ECommerceSite.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\_ViewImports.cshtml"
using ECommerceSite.UI;

#line default
#line hidden
#line 2 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3431d043d7d333837d98f167d5bf50c0fafaff", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2819ddb2a739a1b9238b2313a494784a062a555", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shirts.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 647, true);
            WriteLiteral(@"
    <div id=""flow"">
        <span class=""flow-1""></span>
        <span class=""flow-2""></span>
        <span class=""flow-3""></span>
    </div>        

    <div class=""section"">
        <div class=""box"">
            <div class=""field has-addons"">
                <div class=""control is-expanded"">
                    <input class=""input has-text-centered"" type=""search"" placeholder=""Find a Product"">
                </div>
                <div class=""control"">
                    <a class=""button is-info"">Search</a>
                </div>
            </div>
        </div>
        <div class=""columns is-multiline is-mobile"">
");
            EndContext();
#line 25 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
              
                foreach (var p in Model.Products)
                {

#line default
#line hidden
            BeginContext(804, 111, true);
            WriteLiteral("                    <div class=\"column is-one-third-desktop is-4-tablet is-6-mobile\">\r\n                        ");
            EndContext();
            BeginContext(915, 2275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf0cbe10d4442a4ae4f1258439c0080", async() => {
                BeginContext(1003, 214, true);
                WriteLiteral("\r\n                            <div class=\"card large\">\r\n                                <div class=\"card-image\">\r\n                                    <figure class=\"image\">\r\n                                        ");
                EndContext();
                BeginContext(1217, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0f5f363572a4086b9d67e5b32e6b1a1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1250, 341, true);
                WriteLiteral(@"
                                    </figure>
                                </div>
                                <div class=""card-content"">
                                    <div class=""media"">
                                        <div class=""media-content"">
                                            <p class=""title is-4"">");
                EndContext();
                BeginContext(1592, 6, false);
#line 39 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                                             Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1598, 75, true);
                WriteLiteral("</p>\r\n                                            <p class=\"subtitle is-6\">");
                EndContext();
                BeginContext(1674, 7, false);
#line 40 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                                                Write(p.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1681, 197, true);
                WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"content\">\r\n                                        ");
                EndContext();
                BeginContext(1879, 13, false);
#line 44 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                   Write(p.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1892, 46, true);
                WriteLiteral("\r\n                                    </div>\r\n");
                EndContext();
#line 46 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                      
                                        string cssClass = "";
                                        string message = "";

                                        if (p.StockCount == 0)
                                        {
                                            cssClass = "is-danger";
                                            message = "Out of Stock";

                                        }
                                        else if (p.StockCount <= 10)
                                        {
                                            cssClass = "is-warning";
                                            message = "Low on Stock";
                                        }
                                    

#line default
#line hidden
                BeginContext(2733, 36, true);
                WriteLiteral("                                    ");
                EndContext();
#line 62 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                     if (p.StockCount <= 10)
                                    {

#line default
#line hidden
                BeginContext(2834, 44, true);
                WriteLiteral("                                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2878, "\"", 2941, 4);
                WriteAttributeValue("", 2886, "notification", 2886, 12, true);
                WriteAttributeValue(" ", 2898, "is-paddingless", 2899, 15, true);
                WriteAttributeValue(" ", 2913, "has-text-centered", 2914, 18, true);
#line 64 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
WriteAttributeValue(" ", 2931, cssClass, 2932, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2942, 47, true);
                WriteLiteral(">\r\n                                            ");
                EndContext();
                BeginContext(2990, 7, false);
#line 65 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                       Write(message);

#line default
#line hidden
                EndContext();
                BeginContext(2997, 50, true);
                WriteLiteral("\r\n                                        </div>\r\n");
                EndContext();
#line 67 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(3086, 100, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                                                  WriteLiteral(p.Name.Replace(" ", "-"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3190, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 72 "C:\Users\bagge\Documents\E-Commerce-Site\ECommerceSite.UI\Pages\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3254, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
