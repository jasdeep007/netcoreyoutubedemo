#pragma checksum "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a35adf4b0fea4ac088631f2c232259aadb384c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Other), @"mvc.1.0.view", @"/Views/Home/Other.cshtml")]
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
#line 1 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
using youtubedemonetcore.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a35adf4b0fea4ac088631f2c232259aadb384c", @"/Views/Home/Other.cshtml")]
    public class Views_Home_Other : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
  
    var empdata = JsonConvert.DeserializeObject<List<Employee>>(TempData["Data"].ToString());


#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Department</th>\r\n            <th>Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
         foreach (var data in empdata)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
               Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
               Write(data.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\jasdeep\source\repos\youtubedemonetcore\Views\Home\Other.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
