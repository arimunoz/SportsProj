#pragma checksum "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15960843508ccc36d2bf0ae86e9410fcbb20496e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsProj.Pages.Pages_Batting), @"mvc.1.0.razor-page", @"/Pages/Batting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Batting.cshtml", typeof(SportsProj.Pages.Pages_Batting), null)]
namespace SportsProj.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/_ViewImports.cshtml"
using SportsProj;

#line default
#line hidden
#line 3 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/_ViewImports.cshtml"
using SportsProj.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15960843508ccc36d2bf0ae86e9410fcbb20496e", @"/Pages/Batting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73f88d233a4c37c0a836f6b6232397732a3075d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Batting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 304, true);
            WriteLiteral(@"

<script>function myFunction(x) {
        $(""#item_view"").modal();
    };
    $(document).ready(function () {
        $(""#success-alert"").hide();
        $(""#success-alert"").fadeTo(2000, 500).slideUp(500, function () {
            $(""#success-alert"").slideUp(500);
        });
    });</script>

<html>

");
            EndContext();
            BeginContext(335, 5139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15960843508ccc36d2bf0ae86e9410fcbb20496e3602", async() => {
                BeginContext(341, 231, true);
                WriteLiteral("\n\n\n\n\n    <div class=\"container\">\n        <div class=\"mail-box\">\n            <aside class=\"lg-side\">\n                <div class=\"inbox-head\">\n                    <h3>Batting Stats</h3>\n                </div>\n\n                <br />\n");
                EndContext();
#line 32 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                  
                    if (!string.IsNullOrEmpty(Model.Message))
                    {

#line default
#line hidden
                BeginContext(675, 235, true);
                WriteLiteral("                        <div class=\"alert alert-success\" id=\"success-alert\" style=\"margin-top: 40px;\">\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\n                            <strong>");
                EndContext();
                BeginContext(911, 13, false);
#line 37 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                               Write(Model.Message);

#line default
#line hidden
                EndContext();
                BeginContext(924, 44, true);
                WriteLiteral(" ! </strong>\n                        </div>\n");
                EndContext();
#line 39 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(1008, 1663, true);
                WriteLiteral(@"
                <div class=""inbox-body"" style=""margin-top:20px;"">
                    <div class=""mail-option"">

                        <table class=""table table-inbox table-hover"" style=""border:2px solid black;"">
                            <thead>
                                <tr class=""unread"">
                                    <th class=""col-sm-2"">Rank</th>
                                    <th class=""col-sm-2"">Player</th>
                                    <th class=""col-sm-2"">Team</th>
                                    <th class=""col-sm-2"">AB</th>
                                    <th class=""col-sm-2"">R</th>
                                    <th class=""col-sm-2"">H</th>
                                    <th class=""col-sm-2"">2B</th>
                                    <th class=""col-sm-2"">3B</th>
                                    <th class=""col-sm-2"">HR</th>
                                    <th class=""col-sm-2"">RBI</th>
                                    <th class=""col-sm-2"">SB</th");
                WriteLiteral(@">
                                    <th class=""col-sm-2"">CS</th>
                                    <th class=""col-sm-2"">BB</th>
                                    <th class=""col-sm-2"">SO</th>
                                    <th class=""col-sm-2"">AVG</th>
                                    <th class=""col-sm-2"">OBP</th>
                                    <th class=""col-sm-2"">SLG</th>
                                    <th class=""col-sm-2"">OPS</th>
                                    <th class=""col-sm-2"">WAR</th>

                                </tr>
                            </thead>
                            <tbody>
");
                EndContext();
#line 71 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                 foreach (var item in Model.batting)
                                {

#line default
#line hidden
                BeginContext(2774, 148, true);
                WriteLiteral("                                    <tr>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(2923, 9, false);
#line 74 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.rank);

#line default
#line hidden
                EndContext();
                BeginContext(2932, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3051, 11, false);
#line 75 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.player);

#line default
#line hidden
                EndContext();
                BeginContext(3062, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3181, 9, false);
#line 76 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.team);

#line default
#line hidden
                EndContext();
                BeginContext(3190, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3309, 7, false);
#line 77 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.AB);

#line default
#line hidden
                EndContext();
                BeginContext(3316, 119, true);
                WriteLiteral("</h5></td>\n\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3436, 6, false);
#line 79 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.R);

#line default
#line hidden
                EndContext();
                BeginContext(3442, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3561, 6, false);
#line 80 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.H);

#line default
#line hidden
                EndContext();
                BeginContext(3567, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3686, 4, false);
#line 81 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(3690, 121, true);
                WriteLiteral(".2B</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3812, 4, false);
#line 82 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(3816, 121, true);
                WriteLiteral(".3B</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(3938, 7, false);
#line 83 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.HR);

#line default
#line hidden
                EndContext();
                BeginContext(3945, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4064, 8, false);
#line 84 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.RBI);

#line default
#line hidden
                EndContext();
                BeginContext(4072, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4191, 7, false);
#line 85 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.SB);

#line default
#line hidden
                EndContext();
                BeginContext(4198, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4317, 7, false);
#line 86 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.CS);

#line default
#line hidden
                EndContext();
                BeginContext(4324, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4443, 7, false);
#line 87 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.BB);

#line default
#line hidden
                EndContext();
                BeginContext(4450, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4569, 7, false);
#line 88 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.SO);

#line default
#line hidden
                EndContext();
                BeginContext(4576, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4695, 8, false);
#line 89 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.AVG);

#line default
#line hidden
                EndContext();
                BeginContext(4703, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4822, 8, false);
#line 90 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.OBP);

#line default
#line hidden
                EndContext();
                BeginContext(4830, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(4949, 8, false);
#line 91 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.SLG);

#line default
#line hidden
                EndContext();
                BeginContext(4957, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(5076, 8, false);
#line 92 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.OPS);

#line default
#line hidden
                EndContext();
                BeginContext(5084, 118, true);
                WriteLiteral("</h5></td>\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  text-left\"><h5>");
                EndContext();
                BeginContext(5203, 8, false);
#line 93 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                                                                                      Write(item.WAR);

#line default
#line hidden
                EndContext();
                BeginContext(5211, 54, true);
                WriteLiteral("</h5></td>\n\n                                    </tr>\n");
                EndContext();
#line 96 "/Users/arelimunoz/Documents/Capstone/Project/SportsProj/Pages/Batting.cshtml"
                                }

#line default
#line hidden
                BeginContext(5299, 168, true);
                WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </aside>\n        </div>\n    </div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5474, 10, true);
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BattingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BattingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BattingModel>)PageContext?.ViewData;
        public BattingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591