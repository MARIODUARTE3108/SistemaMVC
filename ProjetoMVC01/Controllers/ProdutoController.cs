using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC01.Entities;
using ProjetoMVC01.Models;
using ProjetoMVC01.Reports;
using ProjetoMVC01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoCadastroModel model, [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = Convert.ToDecimal(model.Preco);
                    produto.Quantidade = Convert.ToInt32(model.Quantidade);

                    produtoRepository.Insetir(produto);

                    TempData["Mensagem"] = $"Produto {produto.Nome}, cadastrado com sucesso!";

                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao cadastrar o produto: " + e.Message;
                }
            }
            return View();
        }



    public IActionResult Consulta([FromServices] ProdutoRepository produtoRepository)
        {
            var model = new ProdutoConsultaModel();
            try
            {
                model.Produtos = produtoRepository.Consultar();
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao consultar o produto: " + e.Message;
            }


            return View(model);
        }

        public IActionResult Exclusao(Guid id, [FromServices] ProdutoRepository produtoRepository)
        {
            try
            {
                var produto = produtoRepository.ObterPorId(id);
                produtoRepository.Excluir(produto);

                TempData["Mensagem"] = $"Produto {produto.Nome}, excluído com sucesso!";
            }
            catch (Exception e )
            {
                TempData["Mensagem"] = "Erro ao consultar o produto: " + e.Message;
                throw;
            }
            return RedirectToAction("Consulta");
        }

        public IActionResult Edicao(Guid id, [FromServices] ProdutoRepository produtoRepository)
        {
            var model = new ProdutoEdicaoModel();

            try
            {
                var produto = produtoRepository.ObterPorId(id);

                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;

            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao exibir o produto: " + e.Message;
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Edicao(ProdutoEdicaoModel model, [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = produtoRepository.ObterPorId(model.IdProduto);

                    produto.Nome = model.Nome;
                    produto.Preco = Convert.ToDecimal( model.Preco);
                    produto.Quantidade = Convert.ToInt32(model.Quantidade);

                    produtoRepository.Alterar(produto);
                    TempData["Mesangem"] = $"Produto {produto.Nome}, atualizado com sucesso!";

                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao atualizar o produto!" + e.Message;
                    throw;
                }

            }

            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Relatorio(ProdutoRelatorioModel model, [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var filtroDataMin = Convert.ToDateTime(model.DataMin);
                    var filtroDataMax = Convert.ToDateTime(model.DataMax);

                    var produtos = produtoRepository.ConsultarPorDatas(filtroDataMin, filtroDataMax);

                    

                    if (model.TipoRelatorio.Equals("pdf"))
                    {
                        var produtoReport = new ProdutoReportPdf();
                        var pdf = produtoReport.GerarPdf(filtroDataMin, filtroDataMax, produtos);

                        Response.Clear();
                        Response.ContentType = "application/pdf";
                        Response.Headers.Add("content-disposition",
                         "attachment; filename=produtos.pdf");
                        Response.Body.WriteAsync(pdf, 0, pdf.Length);
                        Response.Body.Flush();
                        Response.StatusCode = StatusCodes.Status200OK;
                    }
                    else if (model.TipoRelatorio.Equals("excel"))
                    {
                        var produtoReport = new ProdutoReportExcel();
                        var excel = produtoReport.GerarExcel(filtroDataMin, filtroDataMax, produtos);
                        //fazer o download do arquivo..
                        Response.Clear();
                        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                             Response.Headers.Add("content-disposition","attachment; filename=produtos.xlsx");
                        Response.Body.WriteAsync(excel, 0, excel.Length);
                        Response.Body.Flush();
                        Response.StatusCode = StatusCodes.Status200OK;

                    }


                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao gerar relatório" + e.Message;
                }
            }
            return View();
        }

        public JsonResult ObterDadosGrafico([FromServices] ProdutoRepository produtoRepository)
        {
            try
            {
                return Json(produtoRepository.ConsultarTotal());
            }
            catch (Exception e)
            {
                return Json(e.Message);
            } 
        }
    }
}
