#pragma checksum "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\CGP_calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8080c05fb87154bff0d5a77a5b7b009052c2f3f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CGP_calculator), @"mvc.1.0.view", @"/Views/Home/CGP_calculator.cshtml")]
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
#line 1 "C:\Users\Md Jahan\source\repos\Student Portal\Views\_ViewImports.cshtml"
using Student_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Md Jahan\source\repos\Student Portal\Views\_ViewImports.cshtml"
using Student_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8080c05fb87154bff0d5a77a5b7b009052c2f3f7", @"/Views/Home/CGP_calculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d6ffe86fadcb415cc05245c2fd39c294220092", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CGP_calculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\CGP_calculator.cshtml"
  
    ViewData["Title"] = "CGP_calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div id=""templatemo_header_panel"">
        <!--  Free CSS Template designed by TemplateMo.com  -->
        <div id=""templatemo_site_title"">
            <h1>Software <span>Co.</span></h1>
            <h2>company slogan text goes here</h2>
        </div>

        <div id=""templatemo_search_box"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8080c05fb87154bff0d5a77a5b7b009052c2f3f74443", async() => {
                WriteLiteral("\r\n                <input name=\"keyword\" type=\"text\" value=\"Search...\" id=\"searchfield\" onfocus=\"clearText(this)\" onblur=\"clearText(this)\" />\r\n                <input type=\"submit\" name=\"submit\" id=\"searchbutton\"");
                BeginWriteAttribute("value", " value=\"", 615, "\"", 623, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
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
            WriteLiteral(@"
        </div>

    </div> <!-- end of header panel -->

    <div id=""templatemo_banner_panel"">

        <div id=""templatemo_banner_section"">
            <h1>New Website Editor</h1>
            <p>
                Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nunc quis sem nec tellus blandit tincidunt. Aliquam tristique lacus in sapien.
                Aliquam tristique lacus in sapien.
            </p>
            <div class=""readmore""><a href=""#"">Read more</a></div>

        </div> <!-- end of banner section -->

        <div id=""templatemo_menu_section"">
            <ul>
                <li><a href=""http://www.templatemo.com"" target=""_parent"" class=""current"">01<span class=""current"">Home</span></a></li>
                <li><a href=""http://www.templatemo.com/page/1"" target=""_parent"">02<span>Products</span></a></li>
                <li><a href=""http://www.templatemo.com/page/2"" target=""_parent"">03<span>Partners</span></a></li>
                <li><a href=""#"">04<span>Support<");
            WriteLiteral(@"/span></a></li>
                <li><a href=""#"">05<span>About Us</span></a></li>
                <li><a href=""#"">06<span>Contact Us</span></a></li>
            </ul>
        </div> <!-- end of menu section -->

    </div> <!-- end of banner panel -->

    <div id=""templatemo_content_top""></div>
    <div id=""templatemo_content"">

        <div id=""templatemo_content_left"">
            <h1>Welcome to our website</h1>
            <p>This free <a href=""http://www.templatemo.com/page/1"" target=""_parent"">Software Template</a> is provided by <a title=""Free CSS Template"" href=""http://www.templatemo.com"" target=""_parent"">templatemo.com</a>. You may download, modify and apply this template for your personal or business websites.</p>
            <p>Sed consectetur, lacus et dictum tristique, odio neque elementum ante, nec eleifend leo dolor vel tortor. Vivamus vulputate felis. Etiam luctus. Quisque facilisis suscipit elit. Curabitur eleifend.</p>

            <div class=""cleaner_with_height"">&nbsp;</div>");
            WriteLiteral(@"

            <div class=""content_left_two_column"">
                <h2>Our Services</h2>
                <p>Aenean eleifend, neque hendrerit elementum sodales, odio erat sagittis quam, sed tempor orci magna vitae tellus.</p>
                <ul>
                    <li>Quisque facilisis suscipit elit</li>
                    <li>Lacus et dictum tristique</li>
                    <li>Eeros ac tincidunt aliquam</li>
                    <li>Nullam commodo arcu non facilisis</li>
                    <li>Lorem ipsum dolor sit amet</li>
                    <li>Donec felis. Pellentesque leo lacus</li>
                </ul>
                <div class=""readmore""><a href=""#"">Read more</a></div>
            </div>
            <div class=""content_left_two_column"">
                <h2>Our News</h2>
                <h4>[October 24, 2048]</h4>
                <h3>Donec euismod enim et risus</h3>
                <p>
                    <br />
                    Nunc aliquam, dolor vitae sollicitudin lac");
            WriteLiteral(@"inia, nibh orci sagittis diam, dignissim sodales dui erat nec eros.
                </p>
                <div class=""readmore""><a href=""#"">Read more</a></div>

                <div style=""clear: both; margin-top: 30px;"">
                    <a href=""http://validator.w3.org/check?uri=referer""><img style=""border:0;width:88px;height:31px"" src=""http://www.w3.org/Icons/valid-xhtml10"" alt=""Valid XHTML 1.0 Transitional"" width=""88"" height=""31"" vspace=""8"" border=""0"" /></a>
                    <a href=""http://jigsaw.w3.org/css-validator/check/referer""><img style=""border:0;width:88px;height:31px"" src=""http://jigsaw.w3.org/css-validator/images/vcss-blue"" alt=""Valid CSS!"" vspace=""8"" border=""0"" /></a>
                </div>

            </div>

            <div class=""cleaner""></div>
        </div> <!-- end of content left -->

        <div id=""templatemo_content_right"">

            <div class=""content_right_product_01"">
                <h1>Full Package</h1>
                <h2>Vivamus felis?</h2>
     ");
            WriteLiteral(@"           <ul>
                    <li>&raquo; Eeros ac tincidunt</li>
                    <li>&raquo; Aliquam tristique lacus</li>
                    <li>&raquo; Lacus et dictum tristique</li>
                </ul>
                <div class=""readmore""><a href=""#"">Details</a></div>
            </div>

            <div class=""content_right_product_02"">
                <h1>Basic Package</h1>
                <h2>Curabitur eleifend?</h2>
                <ul>
                    <li>&raquo; Aliquam tristique lacu</li>
                    <li>&raquo; Nunc aliquam dolor vitae</li>
                    <li>&raquo; Quisque facilisis suscipit</li>
                </ul>
                <div class=""readmore""><a href=""#"">Details</a></div>
            </div>

        </div> <!-- end of content right -->

    </div>
    <div id=""templatemo_content_bottom""></div>

");
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
