#pragma checksum "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindEmployees\Areas\PacktFeatures\Pages\Shared\_Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae608b9ced38775d7c8aa8c6aecd53b2db58387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeatures_Pages_Shared__Employee), @"mvc.1.0.view", @"/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae608b9ced38775d7c8aa8c6aecd53b2db58387", @"/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml")]
    public class Areas_PacktFeatures_Pages_Shared__Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\n  <div class=\"card-header\">");
#nullable restore
#line 3 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindEmployees\Areas\PacktFeatures\Pages\Shared\_Employee.cshtml"
                      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 3 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindEmployees\Areas\PacktFeatures\Pages\Shared\_Employee.cshtml"
                                       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n  <div class=\"card-body text-dark\">\n    <h5 class=\"card-title\">");
#nullable restore
#line 5 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindEmployees\Areas\PacktFeatures\Pages\Shared\_Employee.cshtml"
                      Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <p class=\"card-text\">");
#nullable restore
#line 6 "E:\C#_Projects\C#7C\Csharp7C\3P\PracticalApps\NorthwindEmployees\Areas\PacktFeatures\Pages\Shared\_Employee.cshtml"
                    Write(Model.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
