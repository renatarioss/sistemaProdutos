#pragma checksum "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f0f2d05b3c119623d14dbbd39844b3032c66e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Edicao), @"mvc.1.0.view", @"/Views/Produto/Edicao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Edicao.cshtml", typeof(AspNetCore.Views_Produto_Edicao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f0f2d05b3c119623d14dbbd39844b3032c66e5", @"/Views/Produto/Edicao.cshtml")]
    public class Views_Produto_Edicao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Presentation.Models.ProdutoEdicaoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
  
    ViewData["Title"] = "Cadastro";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 45, true);
            WriteLiteral("\r\n<h4>Atualização de Produto</h4>\r\n<hr />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(225, 104, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n\r\n            <!-- Campo oculto -->\r\n            ");
            EndContext();
            BeginContext(330, 40, false);
#line 17 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
       Write(Html.HiddenFor(model => model.IdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(370, 61, true);
            WriteLiteral("\r\n\r\n            <label>Nome do Produto:</label>\r\n            ");
            EndContext();
            BeginContext(432, 69, false);
#line 20 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
       Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(501, 58, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(560, 46, false);
#line 22 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(606, 92, true);
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Preço:</label>\r\n            ");
            EndContext();
            BeginContext(699, 70, false);
#line 27 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
       Write(Html.TextBoxFor(model => model.Preco, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(769, 58, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(828, 47, false);
#line 29 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(875, 97, true);
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Quantidade:</label>\r\n            ");
            EndContext();
            BeginContext(973, 75, false);
#line 34 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
       Write(Html.TextBoxFor(model => model.Quantidade, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 58, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(1107, 52, false);
#line 36 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 214, true);
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <input type=\"submit\" value=\"Atualizar Produto\"\r\n                   class=\"btn btn-primary\" />\r\n            <br />\r\n            <br />\r\n\r\n            <strong>");
            EndContext();
            BeginContext(1374, 20, false);
#line 45 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
               Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 41, true);
            WriteLiteral("</strong>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Users\COTI-MAQ02\Desktop\Aula_14.10.19\Aula24\Projeto.Presentation\Views\Produto\Edicao.cshtml"
}

#line default
#line hidden
            BeginContext(1438, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Presentation.Models.ProdutoEdicaoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
