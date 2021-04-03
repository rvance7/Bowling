#pragma checksum "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30fb2a38ec85ac2040c652526420ad001aa591c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30fb2a38ec85ac2040c652526420ad001aa591c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f365aef39f158eb499b8e61430d06321ab806d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Assignment10.Infrastructure.PaginationTagHelper __Assignment10_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewData["SelectedType"] = Model.TeamCategory;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <h1>Bowling Is Kool</h1>\n    <h2>");
#nullable restore
#line 10 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
   Write(ViewData["SelectedType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    
    <div>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>&nbsp; Name &nbsp;</th>
                    <th>&nbsp; Address &nbsp;</th>
                    <th>&nbsp; Phone Number &nbsp;</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                 foreach (var x in Model.Bowlers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 25 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                       Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                                          Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                                                              Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
#nullable restore
#line 27 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                       Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 27 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                                         Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 27 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                                                        Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                            ");
#nullable restore
#line 28 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                       Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>");
#nullable restore
#line 30 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                       Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 32 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n        </table>\n    </div>\n     \n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30fb2a38ec85ac2040c652526420ad001aa591c8095", async() => {
            }
            );
            __Assignment10_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Assignment10.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Assignment10_Infrastructure_PaginationTagHelper);
#nullable restore
#line 38 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Assignment10_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-teamName", "Assignment10.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 38 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamName"] = Model.TeamCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-teamName", __Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Assignment10_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Assignment10_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Assignment10_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 40 "/Users/rachelvance/Projects/Assignment10/Assignment10/Views/Home/Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Assignment10_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591