#pragma checksum "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a768f05ed793413c21be8587f7eeddc687090626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_customers_by_country), @"mvc.1.0.razor-page", @"/Pages/customers-by-country.cshtml")]
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
#line 2 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
using Packt.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a768f05ed793413c21be8587f7eeddc687090626", @"/Pages/customers-by-country.cshtml")]
    public class Pages_customers_by_country : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\n  <h1 class=\"display-2\">Customers By Country</h1>\n  <table class=\"table\">\n    <thead class=\"thead-inverse\">\n      <tr><th>Country</th><th>Company</th></tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 12 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
     foreach(IGrouping<string, Customer> country in Model.CustomersByCountry)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n        <td>");
#nullable restore
#line 15 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
       Write(country.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n          <ul>\n");
#nullable restore
#line 18 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
           foreach (Customer customer in country)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a768f05ed793413c21be8587f7eeddc6870906264171", async() => {
                WriteLiteral("\n                ");
#nullable restore
#line 22 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
           Write(customer.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n              ");
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
#nullable restore
#line 21 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
                                       WriteLiteral(customer.CustomerID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </li>\n");
#nullable restore
#line 25 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </ul>\n        </td>\n      </tr>\n");
#nullable restore
#line 29 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindWeb\Pages\customers-by-country.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindWeb.Pages.CustomersByCountryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.CustomersByCountryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.CustomersByCountryModel>)PageContext?.ViewData;
        public NorthwindWeb.Pages.CustomersByCountryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
