#pragma checksum "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6a205467446cf2c992f83d49cfe2482b00d92b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewWebPage.Pages.Pages_Calculator), @"mvc.1.0.razor-page", @"/Pages/Calculator.cshtml")]
namespace NewWebPage.Pages
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
#line 1 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\_ViewImports.cshtml"
using NewWebPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a205467446cf2c992f83d49cfe2482b00d92b", @"/Pages/Calculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3682f39ce4bc59c9483d3d180f4be5724b815850", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Calculator : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
  
    ViewData["Title"] = "Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Welcome to the E-Web Calculator v0.1</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
   
    var num1 = Request.Query["num1"];
    var num2 = Request.Query["num2"];
    var anum = "Hello";
    //int numQueries = 0;



    if (String.IsNullOrEmpty(num1 = Request.Query["num1"]) || String.IsNullOrEmpty(num2))
    {
        anum = "";
    }
    else
    {
        anum = $"{num1} + {num2} = {Convert.ToString(Convert.ToInt32(num1) + Convert.ToInt32(num2))}";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c6a205467446cf2c992f83d49cfe2482b00d92b4496", async() => {
                WriteLiteral("\r\n    <label for=\"num1\">Enter a number</label>\r\n    <input type=\"text\" name=\"num1\" />\r\n    <br />\r\n    <label for=\"num2\">Enter a number</label>\r\n    <input type=\"text\" name=\"num2\" />\r\n    <button type=\"submit\">Add</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
Write(anum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"color : red\">\r\n    ");
#nullable restore
#line 40 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
Write(ViewData["view1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
Write(ViewData["numQ"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
   string abook = Convert.ToString(ViewData["numQ"]); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Markus\source\repos\NewWebPage\NewWebPage\Pages\Calculator.cshtml"
Write(abook);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewWebPage.Pages.CalculatorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewWebPage.Pages.CalculatorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewWebPage.Pages.CalculatorModel>)PageContext?.ViewData;
        public NewWebPage.Pages.CalculatorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
