#pragma checksum "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62eb6f5520ef8c42e7b85d86fe97d4f653a83882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62eb6f5520ef8c42e7b85d86fe97d4f653a83882", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 48, true);
            WriteLiteral("\r\n<h3>Produto -> Visualizar</h3>\r\n:)\r\n\r\nRazor:\r\n");
            EndContext();
#line 7 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Elias Ribeiro";

#line default
#line hidden
            BeginContext(126, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(131, 4, false);
#line 10 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
            EndContext();
            BeginContext(135, 48, true);
            WriteLiteral("</h3>\r\n<br />\r\n<h2>Produto</h2>\r\n<b>Código:</b> ");
            EndContext();
            BeginContext(184, 8, false);
#line 13 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(192, 22, true);
            WriteLiteral(" <br />\r\n<b>Nome:</b> ");
            EndContext();
            BeginContext(215, 10, false);
#line 14 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(225, 27, true);
            WriteLiteral(" <br />\r\n<b>Descrição:</b> ");
            EndContext();
            BeginContext(253, 15, false);
#line 15 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(268, 23, true);
            WriteLiteral(" <br />\r\n<b>Valor:</b> ");
            EndContext();
            BeginContext(292, 25, false);
#line 16 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(317, 57, true);
            WriteLiteral(" <br />\r\n\r\n\r\n<br />\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(375, 17, false);
#line 20 "C:\Users\leticia.franco\Documents\projetos\cursoudemy\lojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
