#pragma checksum "C:\Users\ERDEM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\LayoutPartial\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fe563dba7dad8d6aa7b24e4f7b9f951b625cd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__FooterPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_FooterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fe563dba7dad8d6aa7b24e4f7b9f951b625cd4", @"/Views/LayoutPartial/_FooterPartial.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
    <!-- footer -->
    <section class=""w3l-footer"">
        <div class=""w3l-footer-16-main py-5"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 column"">
                        <div class=""row"">
                            <div class=""col-md-4 column"">
                                <h3>Company</h3>
                                <ul class=""footer-gd-16"">
                                    <li><a href=""index.html"">Home</a></li>
                                    <li><a href=""about.html"">About Us</a></li>
                                    <li><a href=""services.html"">Services</a></li>
                                    <li><a href=""blog.html"">Blog</a></li>
                                    <li><a href=""contact.html"">Contact Us</a></li>
                                </ul>
                            </div>
                            <div class=""col-md-4 column mt-md-0 mt-4"">
                                <");
            WriteLiteral(@"h3>Useful Links</h3>
                                <ul class=""footer-gd-16"">
                                    <li><a href=""#url"">Destinations</a></li>
                                    <li><a href=""#url"">Our Branches</a></li>
                                    <li><a href=""#url"">Latest Media</a></li>
                                    <li><a href=""about.html"">About Company</a></li>
                                    <li><a href=""#url"">Our Packages</a></li>
                                </ul>
                            </div>
                            <div class=""col-md-4 column mt-md-0 mt-4"">
                                <h3>Our Services</h3>
                                <ul class=""footer-gd-16"">
                                    <li><a href=""#url"">Privacy Policy</a></li>
                                    <li><a href=""#url"">Our Terms</a></li>
                                    <li><a href=""services.html"">Services</a></li>
                                    <li><a href");
            WriteLiteral(@"=""landing-single.html"">Landing Page</a></li>
                                    <li><a href=""#url"">Our Guides</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-12 column pl-lg-5 column4 mt-lg-0 mt-5"">
                        <h3>Newsletter </h3>
                        <div class=""end-column"">
                            <h4>Get latest updates and offers.</h4>
                            <form action=""#"" class=""subscribe"" method=""post"">
                                <input type=""email"" name=""email"" placeholder=""Email Address""");
            BeginWriteAttribute("required", " required=\"", 2731, "\"", 2742, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <button type=""submit"">Go</button>
                            </form>
                            <p>Sign up for our latest news & articles. We won’t give you spam mails.</p>
                        </div>
                    </div>
                </div>
                <div class=""d-flex below-section justify-content-between align-items-center pt-4 mt-5"">
                    <div class=""columns text-lg-left text-center"">
                        <p>
                            &copy; 2020 Traversal. All rights reserved.Design by <a href=""https://w3layouts.com/"" target=""_blank"">
                                W3Layouts
                            </a>
                        </p>
                    </div>
                    <div class=""columns-2 mt-lg-0 mt-3"">
                        <ul class=""social"">
                            <li>
                                <a href=""#facebook""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
        ");
            WriteLiteral(@"                    </li>
                            <li>
                                <a href=""#linkedin""><span class=""fa fa-linkedin"" aria-hidden=""true""></span></a>
                            </li>
                            <li>
                                <a href=""#twitter""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                            </li>
                            <li>
                                <a href=""#google""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                            </li>
                            <li>
                                <a href=""#github""><span class=""fa fa-github"" aria-hidden=""true""></span></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <!-- move top -->
        <button onclick=""topFunction()"" id=""movetop"" title=""Go to top"">
            <span class=""fa fa-angle-up""></span>
   ");
            WriteLiteral(@"     </button>
        <script>
            // When the user scrolls down 20px from the top of the document, show the button
            window.onscroll = function () {
                scrollFunction()
            };

            function scrollFunction() {
                if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
                    document.getElementById(""movetop"").style.display = ""block"";
                } else {
                    document.getElementById(""movetop"").style.display = ""none"";
                }
            }

            // When the user clicks on the button, scroll to the top of the document
            function topFunction() {
                document.body.scrollTop = 0;
                document.documentElement.scrollTop = 0;
            }
        </script>
        <!-- //move top -->
        <script>
            $(function () {
                $('.navbar-toggler').click(function () {
                    $('body').toggleClass('n");
            WriteLiteral("oscroll\');\r\n                })\r\n            });\r\n        </script>\r\n    </section>\r\n    <!-- //footer -->\r\n</footer>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
