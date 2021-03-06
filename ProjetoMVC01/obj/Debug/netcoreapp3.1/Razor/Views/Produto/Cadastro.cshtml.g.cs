#pragma checksum "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae034736b938b73731f28a848570da605cca0f88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastro), @"mvc.1.0.view", @"/Views/Produto/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae034736b938b73731f28a848570da605cca0f88", @"/Views/Produto/Cadastro.cshtml")]
    public class Views_Produto_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoMVC01.Models.ProdutoCadastroModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
  
    ViewBag.Title = "Cadastro";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Cadastro de Produto</h3>\r\n\r\n<p>\r\n    Preencha o formulário para incluir um produto.\r\n</p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\" alert alert-secondary mb-2\" >\r\n            <strong>");
#nullable restore
#line 18 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
               Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Nome do produto:</label>\r\n");
#nullable restore
#line 25 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">\r\n        ");
#nullable restore
#line 27 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
   Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <label>Preço do produto:</label>\r\n");
#nullable restore
#line 32 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
Write(Html.TextBoxFor(model => model.Preco, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">\r\n        ");
#nullable restore
#line 34 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
   Write(Html.ValidationMessageFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <label>Quantidade de produto:</label>\r\n");
#nullable restore
#line 39 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
Write(Html.TextBoxFor(model => model.Quantidade, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">\r\n        ");
#nullable restore
#line 41 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"
   Write(Html.ValidationMessageFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Realizar Cadastro\" class=\"btn-success\" />\r\n");
#nullable restore
#line 46 "C:\Users\Mário Duarte\Documents\Mario Duarte\CURSO-C#\Aula-18\Projeto\ProjetoMVC01\ProjetoMVC01\Views\Produto\Cadastro.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoMVC01.Models.ProdutoCadastroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
