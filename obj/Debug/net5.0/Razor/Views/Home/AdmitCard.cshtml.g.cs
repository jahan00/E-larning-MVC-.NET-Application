#pragma checksum "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\AdmitCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02bc6b67b4160c12f335f9dafe39083222d12649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdmitCard), @"mvc.1.0.view", @"/Views/Home/AdmitCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bc6b67b4160c12f335f9dafe39083222d12649", @"/Views/Home/AdmitCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d6ffe86fadcb415cc05245c2fd39c294220092", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdmitCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\AdmitCard.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<p></p>
<div id=""templatemo_menu"">
    <ul>
        <li><a href=""index.html"" class=""current"">Home</a></li>
        <li><a href=""index.html"">Blog</a></li>
        <li><a href=""index.html"">Forum</a></li>
        <li><a href=""index.html"">Gallery</a></li>
        <li><a href=""index.html"">About Us</a></li>
        <li><a href=""index.html"" class=""last"">Contact Us</a></li>
    </ul>
</div> <!-- end of menu -->

<div id=""templatemo_content"">

    <div id=""content_left"">

        <div class=""content_title_01"">Latest Posts</div>

        <div class=""content_left_section"">
            <div class=""date_box"">
                <div class=""day"">
                    28
                </div>
                <div class=""month"">
                    May
                </div>
            </div>
            <div class=""content"">
                <div class=""news_title"">Quisque dictum pharetra</div>
                <p>Sed ut justo id nisi convallis fermentum sit amet at felis. Vivamus id risus urna,");
            WriteLiteral(@" ut ornare mauris.<a href=""#"">Read more...</a></p>
            </div>
            <div class=""cleaner"">&nbsp;</div>
        </div>

        <div class=""cleaner_h30"">&nbsp;</div>

        <div class=""content_left_section"">
            <div class=""date_box"">
                <div class=""day"">
                    14
                </div>
                <div class=""month"">
                    May
                </div>
            </div>
            <div class=""content"">
                <div class=""news_title"">Pellentesque metus</div>
                <p>Nunc ligula erat, porta et ullamcorper vitae, euismod vel massa. Pellentesque elementum euismod lobortis.<a href=""#"">Read more..</a></p>
            </div>
            <div class=""cleaner"">&nbsp;</div>
        </div>

        <div class=""cleaner_h20"">&nbsp;</div>

        <div class=""rc_btn_01""><a href=""#"">Read All</a></div>

        <div class=""cleaner_h40_divider"">&nbsp;</div>

        <div class=""content_title_01"">Subscribe Newslet");
            WriteLiteral("ter</div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bc6b67b4160c12f335f9dafe39083222d126496253", async() => {
                WriteLiteral("\r\n            <label>Please enter your email address.</label>\r\n            <input type=\"text\" id=\"email\" />\r\n            <input class=\"button\" type=\"submit\" value=\"subscribe\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <div class=""cleaner_h30"">&nbsp;</div>
    </div> <!-- end of content left -->

    <div id=""content_right"">

        <div class=""content_title_01"">Welcome to Chrome Design</div>

        <p>This is a free css template provided by <a title=""free website templates"" href=""http://www.templatemo.com"" target=""_parent"">TemplateMo.com</a>. You may download, modify and apply this web template for your business or personal websites. Credits go to <a href=""http://rozairo.deviantart.com"" target=""_blank"">Rozairo</a> for a photoshop brush and <a href=""http://www.photovaco.com/"" target=""_blank"">photovaco.com</a> for photos.</p>

        <div class=""cleaner_h30"">&nbsp;</div>

        <div class=""content_title_02"">Project One goes here</div>
        <img src=""images/templatemo_087_solution.jpg"" alt=""Solution Template"" />
        <p>Suspendisse vestibulum tincidunt eleifend. Donec vel purus odio, non fermentum diam. Ut cursus, nibh nec tincidunt vulputate, magna sapien ullamcorper risus, sed sollicitud");
            WriteLiteral(@"in est est sed tortor. </p>
        <p>Quisque a tortor purus, sit amet mollis mauris. Suspendisse ipsum turpis, pulvinar eget rutrum ac, auctor sed erat. Duis feugiat tortor interdum sem consequat malesuada.</p>
        <div class=""cleaner_h30"">&nbsp;</div>

        <div class=""content_title_02"">Project Two goes here</div>
        <img src=""images/templatemo_092_software.jpg"" alt=""Software Co. Template"" />
        <p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vehicula est est, at fermentum eros. Curabitur auctor odio id neque placerat imperdiet. </p>
        <p>Aliquam nisl elit, scelerisque ut blandit a, porta vitae lacus. Mauris lobortis consequat dui sed porttitor. Aenean vitae quam sed purus lacinia semper. Nullam ac risus sapien, sed bibendum mi. Donec at nisi enim.</p>
        <div class=""cleaner"">&nbsp;</div>
    </div> <!-- end of content right -->

    <div class=""cleaner_h30"">&nbsp;</div>

    <div id=""content_bottom"">
        <div cl");
            WriteLiteral(@"ass=""content_title_01"">Our Partners</div>

        <div class=""content_bottom_box"">
            <a href=""http://www.flashmo.com/"" target=""_blank"" title=""Free Flash Templates""><img src=""images/flashmo.gif"" alt=""Free Flash Resources"" /></a>
            <p>FlashMo.com provides free flash source files for flash templates, flash galleries, flash intros, etc.</p>

        </div>

        <div class=""content_bottom_box"">
            <a href=""http://www.templatemo.com/"" target=""_blank"" title=""Free CSS Templates""><img src=""images/templatemo.gif"" alt=""Free CSS Templates"" /></a>
            <p>TemplateMo.com provides a lot of high quality free css templates for your personal or business websites.</p>
        </div>

        <div class=""content_bottom_box"">
            <a href=""http://www.webdesignmo.com/"" target=""_blank"" title=""Web Design Blog""><img src=""images/webdesignmo.gif"" alt=""Free Flash Resources"" /></a>
            <p>Web design blog features many articles including useful tips and techniques abou");
            WriteLiteral(@"t web design and flash.</p>
        </div>

        <div class=""content_bottom_box"">
            <a href=""http://www.cssmodel.com/"" target=""_blank"" title=""CSS Tips and Tricks""><img src=""images/cssmodel.gif"" alt=""CSS blog"" /></a>
            <p>CSS Model is sharing collections of useful links, tips and tricks for all levels of CSS designers or learners.</p>
        </div>

        <div class=""cleaner_h30"">&nbsp;</div>
    </div> <!-- end of content bottom -->

    <div class=""cleaner_h30"">&nbsp;</div>
    <div id=""templatemo_content_bottom"">&nbsp;</div>
</div> <!-- end of content -->
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