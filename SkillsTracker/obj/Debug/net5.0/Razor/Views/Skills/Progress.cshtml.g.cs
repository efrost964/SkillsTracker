#pragma checksum "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\Skills\Progress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d912f32eed2aee57ec16d0796ecb46af3d098b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skills_Progress), @"mvc.1.0.view", @"/Views/Skills/Progress.cshtml")]
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
#line 1 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\_ViewImports.cshtml"
using SkillsTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\_ViewImports.cshtml"
using SkillsTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d912f32eed2aee57ec16d0796ecb46af3d098b", @"/Views/Skills/Progress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10fd363435efcebd80dbd932ab3fed24afe9824", @"/Views/_ViewImports.cshtml")]
    public class Views_Skills_Progress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 id=\"title\">Skills Tracker</h1>\r\n<ol>\r\n    <li>C#: ");
#nullable restore
#line 8 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\Skills\Progress.cshtml"
       Write(ViewBag.cSharp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</li>\r\n    <li>Python: ");
#nullable restore
#line 9 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\Skills\Progress.cshtml"
           Write(ViewBag.python);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</li>\r\n    <li>JavaScript: ");
#nullable restore
#line 10 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\Skills\Progress.cshtml"
               Write(ViewBag.javaScript);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</li>\r\n</ol>\r\n<p>Last updated on: ");
#nullable restore
#line 12 "C:\Users\lumpysacks\Desktop\coding\launchCode\Unit-2\chap-10-studio\SkillsTracker\SkillsTracker\Views\Skills\Progress.cshtml"
               Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<a href=\"/Skills/Update\">Update your progress</a>");
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
