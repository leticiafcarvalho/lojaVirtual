#pragma checksum "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3492d200e3bf8787f21b62939df26c82d46e2ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 2 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3492d200e3bf8787f21b62939df26c82d46e2ae", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(40, 942, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f470eb14dea041b582e175f22271e7dd", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e77d41a1dd4f9e8c301f27c67a3655", async() => {
>>>>>>> master
                BeginContext(46, 100, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(147, 13, false);
#line 7 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(160, 761, true);
                WriteLiteral(@"</title>

    <meta name=""description"" content=""Loja Virtual em ASP.NET"">
    <meta name=""author"" content=""Elias Ribeiro"">
    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-4.2.1-dist/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/resources/lib/caroussel/carousel.css"" />
    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-ecommerce-uikit/css/ui.css"" />
    <link rel=""stylesheet"" href=""/resources/lib/bootstrap-ecommerce-uikit/css/responsive.css"" rel=""stylesheet"" media=""only screen and (max-width: 1200px)"" />
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"" integrity=""sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/""
          crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(921, 52, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68ab38ea0ebf4582aaca22885eecd824", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be88a10cbacc478a8a53e895c16c7eab", async() => {
>>>>>>> master
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(973, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(982, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(984, 3334, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b0373e30b24a71a214c4c7816b0239", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a7e50e676a140fc8f6af54af24c68bd", async() => {
>>>>>>> master
                BeginContext(990, 1841, true);
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
            <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/""><i class=""fas fa-home""></i> Home <span class=""sr-only"">(current)</span></a>
                    </li>

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                           aria-ha");
                WriteLiteral(@"spopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-list-ul""></i> Categorias
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Contato""><i class=""far fa-address-book""></i> Contato </a>
                    </li>
                </ul>
                ");
                EndContext();
                BeginContext(2831, 512, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330d6a8a2dff48a29f9bccb06059c16e", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5605a6e1c154534873e7f1899848473", async() => {
>>>>>>> master
                    BeginContext(2870, 466, true);
                    WriteLiteral(@"



                    <input class=""form-control mr-sm-2"" type=""search"" placeholder=""palavra"" aria-label=""Search"">
                    <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Pesquisa</button>
                    <a class=""nav-link"" href=""/Home/Login""><i class=""fas fa-user-alt""></i> Login</a>
                    <a class=""nav-link"" href=""/Home/CarrinhoCompras""><i class=""fas fa-shopping-cart""></i> Carrinho</a>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3343, 72, true);
                WriteLiteral("\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(3416, 12, false);
#line 63 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3428, 193, true);
                WriteLiteral("\r\n    </div>\r\n    <hr class=\"featurette-divider\">\r\n\r\n    <!-- FOOTER -->\r\n    <footer class=\"container\">\r\n        <p class=\"float-right\"><a href=\"#\">Back to top</a></p>\r\n        <p>&copy; 2017-");
                EndContext();
                BeginContext(3622, 17, false);
#line 70 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Shared\_Layout.cshtml"
                  Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(3639, 672, true);
                WriteLiteral(@" - LojaVirtual, Inc. &middot; <a href=""#"">Privacy</a> &middot; <a href=""#"">Terms</a></p>
    </footer>

    <!-- Bootstrap core JavaScript
          ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
    <script src=""/resources/lib/holder/holder.min.js""></script>
    <script src=""/resources/lib/jquery3.3.1/jquery-3.3.1.min.js""></script>
    <script src=""/resources/lib/popper1.14.6/popper.min.js""></script>
    <script src=""/resources/lib/bootstrap-4.2.1-dist/js/bootstrap.min.js""></script>

");
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
            BeginContext(4318, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
