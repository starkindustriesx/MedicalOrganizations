#pragma checksum "C:\Users\Katya\source\repos\MedicalOrganizations\MedicalOrganizations\Views\Organization\GetByIdView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc68412770f4fb3676ef34ede311cc2edb493f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organization_GetByIdView), @"mvc.1.0.view", @"/Views/Organization/GetByIdView.cshtml")]
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
#line 1 "C:\Users\Katya\source\repos\MedicalOrganizations\MedicalOrganizations\Views\_ViewImports.cshtml"
using MedicalOrganizations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Katya\source\repos\MedicalOrganizations\MedicalOrganizations\Views\_ViewImports.cshtml"
using MedicalOrganizations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc68412770f4fb3676ef34ede311cc2edb493f3", @"/Views/Organization/GetByIdView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2177fd971dd906d6e99561d1036b8c461153aab8", @"/Views/_ViewImports.cshtml")]
    public class Views_Organization_GetByIdView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list\">\r\n\r\n<ul>\r\n    <li>\r\n        <p>");
#nullable restore
#line 5 "C:\Users\Katya\source\repos\MedicalOrganizations\MedicalOrganizations\Views\Organization\GetByIdView.cshtml"
      Write(Model.Organization.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 6 "C:\Users\Katya\source\repos\MedicalOrganizations\MedicalOrganizations\Views\Organization\GetByIdView.cshtml"
      Write(Model.Organization.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </li>\r\n    \r\n</ul>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591