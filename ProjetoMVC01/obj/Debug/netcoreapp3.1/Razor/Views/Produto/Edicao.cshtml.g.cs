#pragma checksum "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e67a6e062d3663f21c4a0183c072784a032e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Edicao), @"mvc.1.0.view", @"/Views/Produto/Edicao.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e67a6e062d3663f21c4a0183c072784a032e9f", @"/Views/Produto/Edicao.cshtml")]
    public class Views_Produto_Edicao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoMVC01.Models.ProdutoEdicaoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
  
    ViewBag.Title = "Edicao";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Atualização de Produto</h3>\r\n<p> Utilize o formulário para alterar o produto.</p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-secondary mb-2\">\r\n        <strong>");
#nullable restore
#line 14 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
           Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
Write(Html.HiddenFor(model => model.IdProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Nome do produto:</label>\r\n");
#nullable restore
#line 23 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" text-danger\">\r\n        ");
#nullable restore
#line 25 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
   Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <label>Preço do produto:</label>\r\n");
#nullable restore
#line 30 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
Write(Html.TextBoxFor(model => model.Preco, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" text-danger\">\r\n        ");
#nullable restore
#line 32 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
   Write(Html.ValidationMessageFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <label>Quantidade do produto:</label>\r\n");
#nullable restore
#line 37 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
Write(Html.TextBoxFor(model => model.Quantidade, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" text-danger\">\r\n        ");
#nullable restore
#line 39 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"
   Write(Html.ValidationMessageFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <input type=\"submit\"");
            BeginWriteAttribute("name", " name=", 1191, "", 1197, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Salvar Alterações\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 44 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Edicao.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoMVC01.Models.ProdutoEdicaoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
