#pragma checksum "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d74ad40ddfae2752d8d33a2083d2246efbd8832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_HelloTime), @"mvc.1.0.razor-page", @"/Pages/HelloTime.cshtml")]
namespace WebApplication1.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
using WebApplication1.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d74ad40ddfae2752d8d33a2083d2246efbd8832", @"/Pages/HelloTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc52a73c87a28485eec77c5a5406c85aa3ed24a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HelloTime : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d74ad40ddfae2752d8d33a2083d2246efbd88323490", async() => {
                WriteLiteral("\n    <title></title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d74ad40ddfae2752d8d33a2083d2246efbd88324459", async() => {
                WriteLiteral("\n<div>\n    <h1>Local time is ");
#nullable restore
#line 18 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
                 Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n    \n    <h2> Trying out ViewData - string ");
#nullable restore
#line 20 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
                                 Write(ViewData["MyTitle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    <h2>Trying out ViewData - number ");
#nullable restore
#line 21 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
                                Write(ViewData["MyNumber"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    \n");
#nullable restore
#line 23 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
      
        var post = (Post) ViewData["MyObject"];
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    \n    <h2>Trying out ViewData object: </h2>\n    <p>");
#nullable restore
#line 28 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
  Write(post.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>");
#nullable restore
#line 29 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
  Write(post.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>");
#nullable restore
#line 30 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
  Write(post.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>");
#nullable restore
#line 31 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
  Write(post.LengthMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    \n");
#nullable restore
#line 33 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
   string message = "This is a direct message from the page";

#line default
#line hidden
#nullable disable
                WriteLiteral("    \n    <h2> Message direct from the page : ");
#nullable restore
#line 36 "/Users/Florinelx/Desktop/Session08/Exercises02-07/WebApplication1/WebApplication1/Pages/HelloTime.cshtml"
                                   Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n</div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.HelloTime> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.HelloTime> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.HelloTime>)PageContext?.ViewData;
        public WebApplication1.Pages.HelloTime Model => ViewData.Model;
    }
}
#pragma warning restore 1591
