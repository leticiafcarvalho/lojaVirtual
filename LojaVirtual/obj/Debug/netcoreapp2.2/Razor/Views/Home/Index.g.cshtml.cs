#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebfbe95c3923984d4018471cf17745ac59c99106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfbe95c3923984d4018471cf17745ac59c99106", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.NewsletterEmail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 8954, true);
            WriteLiteral(@"
<main role=""main"">

    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""first-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""First slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-left"">
                        <h1>Example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut ");
            WriteLiteral(@"id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Second slide"">
                <div class=""container"">
                    <div class=""carousel-caption"">
                        <h1>Another example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                    </div>
                </div>");
            WriteLiteral(@"
            </div>
            <div class=""carousel-item"">
                <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Third slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-right"">
                        <h1>One more for good measure.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon");
            WriteLiteral(@""" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>




    <!-- Lista de Produtos
            ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->


    <div class=""container"" id=""code_prod_complex"">
        <div class=""row"">
            <div class=""col-md-4"">
                <figure class=""card card-product"">
                    <div class=""img-wrap""><img src=""images/items/1.jpg""></div>
                    <figcaption class=""info-wrap"">
                        <h4 class=""title"">Another name of item</h4>
                        <p class=""desc"">Some small description goes here</p>
                        <div class=""rat");
            WriteLiteral(@"ing-wrap"">
                            <ul class=""rating-stars"">
                                <li style=""width:80%"" class=""stars-active"">
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                </li>
                                <li>
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                </li>
                            </ul>
                            <div class=""label-rating"">132 reviews</div>
                            <div class=""label-rating"">154 orders </div>
                        </div> <!-- rating-wrap.// -->
                    </figcaption>
                    <div class=""bottom-wrap"">
                        <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                ");
            WriteLiteral(@"        <div class=""price-wrap h5"">
                            <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                        </div> <!-- price-wrap.// -->
                    </div> <!-- bottom-wrap.// -->
                </figure>
            </div> <!-- col // -->
            <div class=""col-md-4"">
                <figure class=""card card-product"">
                    <div class=""img-wrap""><img src=""images/items/2.jpg""> </div>
                    <figcaption class=""info-wrap"">
                        <h4 class=""title"">Good product</h4>
                        <p class=""desc"">Some small description goes here</p>
                        <div class=""rating-wrap"">
                            <ul class=""rating-stars"">
                                <li style=""width:80%"" class=""stars-active"">
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
     ");
            WriteLiteral(@"                           </li>
                                <li>
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                </li>
                            </ul>
                            <div class=""label-rating"">132 reviews</div>
                            <div class=""label-rating"">154 orders </div>
                        </div> <!-- rating-wrap.// -->
                    </figcaption>
                    <div class=""bottom-wrap"">
                        <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                        <div class=""price-wrap h5"">
                            <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                        </div> <!-- price-wrap.// -->
                    </div> <!-- bottom-wrap.// -->
                </figure>
            </div> <!-- col // -->
         ");
            WriteLiteral(@"   <div class=""col-md-4"">
                <figure class=""card card-product"">
                    <div class=""img-wrap""><img src=""images/items/3.jpg""></div>
                    <figcaption class=""info-wrap"">
                        <h4 class=""title"">Product name goes here</h4>
                        <p class=""desc"">Some small description goes here</p>
                        <div class=""rating-wrap"">
                            <ul class=""rating-stars"">
                                <li style=""width:80%"" class=""stars-active"">
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                </li>
                                <li>
                                    <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                </li>
                            <");
            WriteLiteral(@"/ul>
                            <div class=""label-rating"">132 reviews</div>
                            <div class=""label-rating"">154 orders </div>
                        </div> <!-- rating-wrap.// -->
                    </figcaption>
                    <div class=""bottom-wrap"">
                        <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                        <div class=""price-wrap h5"">
                            <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                        </div> <!-- price-wrap.// -->
                    </div> <!-- bottom-wrap.// -->
                </figure>
            </div> <!-- col // -->
        </div> <!-- row.// -->
    </div>
</main>

");
            EndContext();
#line 163 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
  
    /*
     * Razor - Motor Template do ASP.NET
     * Html Helper - Interface que proporciona gerar código HTML por meio do C#, isso ajuda na manipulação de informações entre HTML e Tecnologia ASP.NET
     */

#line default
#line hidden
            BeginContext(9259, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 172 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
 using (Html.BeginForm("index", "home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(9333, 80, true);
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(9414, 24, false);
#line 177 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(9438, 479, true);
            WriteLiteral(@"

                <div class=""col-sm-6 offset-sm-2"">
                    <div class=""form-group"">
                        <label for=""nome"">Cadastre seu e-mail para receber promoções:</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fa  fa-envelope ""></i></span>
                            </div>
                            ");
            EndContext();
            BeginContext(9918, 82, false);
#line 186 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(m=>m.Email, new { htmlAttributes = new { @class="form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10000, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                        <span style=\"color: red;\">");
            EndContext();
            BeginContext(10085, 37, false);
#line 188 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                             Write(Html.ValidationMessageFor(m=>m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(10122, 298, true);
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <br />
                    <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                </div>


            </div>
        </div>
");
            EndContext();
#line 199 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 09\09_Fim\LojaVirtual\Views\Home\Index.cshtml"
    
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.NewsletterEmail> Html { get; private set; }
    }
}
#pragma warning restore 1591