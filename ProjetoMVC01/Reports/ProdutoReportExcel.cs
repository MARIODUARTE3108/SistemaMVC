using OfficeOpenXml;
using OfficeOpenXml.Style;
using ProjetoMVC01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Reports
{
    public class ProdutoReportExcel
    {
        public byte[] GerarExcel(DateTime dataMin, DateTime dataMax, List<Produto> produtos)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var excelPackage = new ExcelPackage())
            {
                var sheet = excelPackage.Workbook.Worksheets.Add("Relatório de Podutos");

                sheet.Cells["A1:E2"].Merge = true;
                sheet.Cells["A1:E6"].Style.Font.Bold = true;
                sheet.Cells["A1:E6"].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;

                sheet.Cells["A1"].Value = "Relatório de Produtos";

                sheet.Cells["A3"].Value = "Data de início:";
                sheet.Cells["B3"].Value = dataMin.ToString("dd/MM/yyyy");

                sheet.Cells["A4"].Value = "Data de término:";
                sheet.Cells["B4"].Value = dataMax.ToString("dd/MM/yyyy");

                sheet.Cells["A6"].Value = "Nome do produto";
                sheet.Cells["B6"].Value = "Preço";
                sheet.Cells["C6"].Value = "Quantidade";
                sheet.Cells["D6"].Value = "Total";
                sheet.Cells["E6"].Value = "Data de Cadastro";
                
                var linha = 7;

                int total = 0;
                int sc = 0;
                decimal sb = 0;
                decimal sd = 0;
                foreach (var item in produtos)
                {
                    sheet.Cells[$"C{linha}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    //sheet.Cells[$"D{linha}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    sheet.Cells[$"E{linha}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;

                    sheet.Cells[$"A{linha}"].Value = item.Nome;
                    sheet.Cells[$"B{linha}"].Value = item.Preco.ToString("c");
                    sheet.Cells[$"C{linha}"].Value = item.Quantidade;
                    sheet.Cells[$"D{linha}"].Value = (item.Preco * item.Quantidade).ToString("c");
                    sheet.Cells[$"E{linha}"].Value = item.DataCadastro.ToString("dd/MM/yyyy");
                    linha++;
                    sb += item.Preco;
                    sc += item.Quantidade;
                    sd += item.Preco* item.Quantidade;
                    total++;

                }
                sheet.Cells[$"A{linha}:E{linha}"].Style.Font.Bold = true;
               sheet.Cells[$"A{linha}:E{linha}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;

                sheet.Cells[$"A{linha}"].Value = "TOTAL:";
                sheet.Cells[$"B{linha}"].Value = sb.ToString("c");
                sheet.Cells[$"C{linha}"].Value = sc;
                sheet.Cells[$"D{linha}"].Value = sd.ToString("c");
                sheet.Cells[$"E{linha}"].Value = total;

                //formatação para ajustar a largura as colunas da planilha
                sheet.Cells["A:E"].AutoFitColumns();
                //finalizar e retornar o arquivo excel..
                return excelPackage.GetAsByteArray();
            }
        }
    }
}
        