#pragma checksum "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b8d83ba4321bd8d6f4017f44d784395f4d327f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8d83ba4321bd8d6f4017f44d784395f4d327f9", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n    ");
            EndContext();
            BeginContext(27, 459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8d83ba4321bd8d6f4017f44d784395f4d327f94405", async() => {
                BeginContext(33, 325, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <title>Order Details</title>
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>
        ");
                EndContext();
                BeginContext(358, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b8d83ba4321bd8d6f4017f44d784395f4d327f95114", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(434, 45, true);
                WriteLiteral("\n        <script src=\"main.js\"></script>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(486, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(491, 632, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8d83ba4321bd8d6f4017f44d784395f4d327f97429", async() => {
                BeginContext(497, 78, true);
                WriteLiteral("\n      <div class=\"container\">\n        <h1>Order Details: </h1>\n          <h2>");
                EndContext();
                BeginContext(576, 20, false);
#line 15 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
         Write(Model["order"].Title);

#line default
#line hidden
                EndContext();
                BeginContext(596, 52, true);
                WriteLiteral("</h2>\n            <ul>\n            <li>Description: ");
                EndContext();
                BeginContext(649, 26, false);
#line 17 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
                        Write(Model["order"].Description);

#line default
#line hidden
                EndContext();
                BeginContext(675, 29, true);
                WriteLiteral("</li>\n            <li>Total: ");
                EndContext();
                BeginContext(705, 19, false);
#line 18 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
                  Write(Model["order"].Cost);

#line default
#line hidden
                EndContext();
                BeginContext(724, 28, true);
                WriteLiteral("</li>\n            <li>Date: ");
                EndContext();
                BeginContext(753, 19, false);
#line 19 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
                 Write(Model["order"].Date);

#line default
#line hidden
                EndContext();
                BeginContext(772, 43, true);
                WriteLiteral(" lbs</li>\n            </ul>\n\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 815, "\'", 861, 3);
                WriteAttributeValue("", 822, "/vendors/", 822, 9, true);
#line 22 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 831, Model["vendor"].Id, 831, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 850, "/orders/new", 850, 11, true);
                EndWriteAttribute();
                BeginContext(862, 101, true);
                WriteLiteral("><button class=\"btn btn-primary\" type=\"click\" name=\"button\">Add An Orders</button></a>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 963, "\'", 1005, 3);
                WriteAttributeValue("", 970, "/vendors/", 970, 9, true);
#line 23 "/Users/topher/Code/Epicodus/OrderTracker.Solution/OrderTracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 979, Model["vendor"].Id, 979, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 998, "/orders", 998, 7, true);
                EndWriteAttribute();
                BeginContext(1006, 110, true);
                WriteLiteral("><button class=\"btn btn-primary\" type=\"click\" name=\"button\">View or Edit Orders</button></a>\n      </div>\n    ");
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
            BeginContext(1123, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
