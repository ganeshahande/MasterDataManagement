#pragma checksum "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c058bb79649d522f5d486779eef63aada1f927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Details), @"mvc.1.0.view", @"/Views/Countries/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Countries/Details.cshtml", typeof(AspNetCore.Views_Countries_Details))]
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
#line 1 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\_ViewImports.cshtml"
using VFS.UI.MasterDM;

#line default
#line hidden
#line 2 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\_ViewImports.cshtml"
using VFS.UI.MasterDM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c058bb79649d522f5d486779eef63aada1f927", @"/Views/Countries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"858505bbd2957410b93f64d64654e1b0c3ee6266", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VFS.Common.Models.Masters.Country>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Country</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 40, false);
#line 15 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 36, false);
#line 18 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 40, false);
#line 21 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(504, 36, false);
#line 24 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(540, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(584, 44, false);
#line 27 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Isocode2));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 40, false);
#line 30 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Isocode2));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(756, 44, false);
#line 33 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Isocode3));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(844, 40, false);
#line 36 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Isocode3));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(928, 44, false);
#line 39 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DialCode));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1016, 40, false);
#line 42 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.DialCode));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1100, 47, false);
#line 45 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1191, 43, false);
#line 48 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1429, 30, true);
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1459, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6db9eb8b1e67485ea1795754d294312c", async() => {
                BeginContext(1505, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "D:\_OFFICE\_SVN\_SCRUM\_APPLICATION\_VFS\MasterDataManagement\Code\MasterDM\UI\VFS.UI.MasterDM\Views\Countries\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1513, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1521, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be599d6152a3451c91cbb368ae3e1ffb", async() => {
                BeginContext(1543, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1559, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VFS.Common.Models.Masters.Country> Html { get; private set; }
    }
}
#pragma warning restore 1591
