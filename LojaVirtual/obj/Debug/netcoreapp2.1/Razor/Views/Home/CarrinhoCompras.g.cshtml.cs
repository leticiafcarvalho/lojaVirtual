#pragma checksum "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a044069a07d2c5fec1cbe00ecfd9aa565ea793f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarrinhoCompras.cshtml", typeof(AspNetCore.Views_Home_CarrinhoCompras))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a044069a07d2c5fec1cbe00ecfd9aa565ea793f", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml"
  
    ViewData["Title"] = "CarrinhoCompras";

#line default
#line hidden
            BeginContext(53, 2057, true);
            WriteLiteral(@"
<main role=""main"">





    <section class=""container"" id=""order"" style=""margin-top: 50px"">

        <h2 class=""title-doc""># Order </h2>


        <h4 class=""subtitle-doc"">
            # Shopping cart
            <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
        </h4>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"">Product</th>
                            <th scope=""col"" width=""120"">Quantity</th>
                            <th scope=""col"" width=""120"">Price</th>
                            <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <figure class=""media"">
             ");
            WriteLiteral(@"                       <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                           ");
            WriteLiteral("         ");
            EndContext();
            BeginContext(2110, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4566c98150a24a4382388a92a0b626e6", async() => {
                BeginContext(2118, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2128, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2166, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "097a5c0251044a1fb083b60d5abdb21f", async() => {
                BeginContext(2174, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2184, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2222, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fcaa05d74414de5b24c2317d1b9eb81", async() => {
                BeginContext(2230, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2240, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2278, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cdb41d339c4fb196de1662f90e672a", async() => {
                BeginContext(2286, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2296, 2012, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 145</var>
                                    <small class=""text-muted"">(USD5 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=""img-wrap"">");
            WriteLiteral(@"<img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                                    ");
            EndContext();
            BeginContext(4308, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0aec12f868c4182a658188a658428d8", async() => {
                BeginContext(4316, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4326, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4364, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58272208cb5f47e3a0cce62286f68780", async() => {
                BeginContext(4372, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4382, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4420, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b869246b1c8e40768a37c5126bdef5e0", async() => {
                BeginContext(4428, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4438, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4476, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ddfacc16c149e6930f37215ff942a8", async() => {
                BeginContext(4484, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4494, 2022, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 35</var>
                                    <small class=""text-muted"">(USD10 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=""");
            WriteLiteral(@"img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                                    ");
            EndContext();
            BeginContext(6516, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08296ae0e8443f098b4e1e16c6c567b", async() => {
                BeginContext(6524, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6534, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6572, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a93e38022e543cf8123a58404d2031a", async() => {
                BeginContext(6580, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6590, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6628, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4c0292354f74b409066ebc686889900", async() => {
                BeginContext(6636, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6646, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6684, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584ae498ca9246bbb474180366c8c458", async() => {
                BeginContext(6692, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6702, 4591, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 45</var>
                                    <small class=""text-muted"">(USD15 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->
    </section>
    <br />
    <br /");
            WriteLiteral(@">
    <section class=""container"">
        <div class=""row"">
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cálculo de frete
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Some info: </dt>
                            <dd>
                                Dolor sit amet, consectetur adipisicing elit do eiusmod
                                tempor incididunt
                            </dd>
                        </dl>
                        <dl>
                            <dt>Parameter: </dt>
                            <dd>Value name</dd>
                        </dl>
                        <dl>
                            <dt>Discount:</dt>
                            <dd>USD 658</dd>
                        </dl>
        ");
            WriteLiteral(@"            </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cupom desconto
                    <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_align"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Some info: </dt>
                            <dd> Everything in this life is always tempporary</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
                            <dd>Value name</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd>Orange and Black</dd>
                        </dl>
                        <dl cl");
            WriteLiteral(@"ass=""dlist-align"">
                            <dt>Material:</dt>
                            <dd>Leather</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Total a pagar
                    <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_right"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
                            <dd class=""text-right"">Value name</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd class=""text-right"">Orange and Black</dd>
                        </dl>
                        <dl class=""dlist-align"">
     ");
            WriteLiteral(@"                       <dt>Material:</dt>
                            <dd class=""text-right"">Leather</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Total cost: </dt>
                            <dd class=""text-right h5 b""> USD195 </dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
        </div>
    </section>
</main>
");
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
