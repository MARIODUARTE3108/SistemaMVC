using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ProjetoMVC01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoMVC01.Reports
{
    public class ProdutoReportPdf
    {
        //método para gerar um relatorio em formato PDF
        //byte[] -> indica que o método retorna um arquivo..

        public byte[] GerarPdf(DateTime dataMin, DateTime dataMax, List<Produto> produtos)
        {
            DateTime printData = DateTime.Now;

            //abrindo o documento PDF..
            var memoryStream = new MemoryStream();
            var pdf = new PdfDocument(new PdfWriter(memoryStream));


            //escrevendo o conteudo do PDF..
            using (var document = new Document(pdf))
            {
               document.Add(new Paragraph($"{printData.ToString("dd/MM/yyyy HH:mm")}")
                    .AddStyle(FormatacaoData)
                    .SetTextAlignment(TextAlignment.LEFT));           

                document.Add(ObterLogotipo);

                document.Add
                (new Paragraph("Relatório de Produtos")
                .AddStyle(FormatacaoTitulo)
                .SetTextAlignment(TextAlignment.CENTER));

                document.Add(
                new Paragraph
                ($"Produtos cadastrados entre:{dataMin.ToString("dd/MM/yyyy")}e { dataMax.ToString("dd/MM/yyyy")}")
                .AddStyle(FormatacaoSubTitulo)
                .SetTextAlignment(TextAlignment.CENTER));

                //escrever uma tabela contendo os produtos..
                var table = new Table(5); //5 -> numero de colunas da tabela
                table.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                table.AddHeaderCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Nome do Produto")));
                table.AddHeaderCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Preço")));
                table.AddHeaderCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Quantidade")));
                table.AddHeaderCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Total")));
                table.AddHeaderCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Data de Cadastro")));

                //exibir os produtos dentro da tabela..
                foreach (var item in produtos)
                {
                    table.AddCell(item.Nome);
                    table.AddCell(item.Preco.ToString("c")); //c -> currency (R$)
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(item.Quantidade.ToString())));
                    table.AddCell((item.Preco * item.Quantidade).ToString("c"));
                    //c -> currency (R$)
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(item.DataCadastro.ToString("dd/MM/yyyy"))));
                }
                document.Add(table); //adicionando a tabela no documento PDF
            }

            return memoryStream.ToArray();
        }
        //método para gerar o estilo do titulo do relatorio..
       private Style FormatacaoTitulo
        {
            get
            {
                var style = new Style();
                style.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD));
                style.SetFontSize(26);
                style.SetFontColor(Color.ConvertRgbToCmyk
               (new DeviceRgb(0, 102, 284)));
                return style;
            }
        }
        //método para gerar o estilo do subtitulo do relatorio..
        private Style FormatacaoSubTitulo
        {
            get
            {
                var style = new Style();
                style.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA));
                style.SetFontSize(13);
                style.SetFontColor(Color.ConvertRgbToCmyk
               (new DeviceRgb(0, 0, 0)));
                return style;
            }
        }
        private Style FormatacaoData
        {
            get
            {
                var style = new Style();
                style.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA));
                style.SetFontSize(7);
                style.SetFontColor(Color.ConvertRgbToCmyk
               (new DeviceRgb(0, 0, 0)));
                return style;
            }
        }
        private Image ObterLogotipo
        {
            get
            {
                ImageData imageData = ImageDataFactory.Create(new Uri("https://www.cotiinformatica.com.br/imagens/logo-coti-informatica.png"));
                var logotipo = new Image(imageData);
                logotipo.SetWidth(200);
                logotipo.SetHorizontalAlignment(HorizontalAlignment.CENTER);

                return logotipo;
             }
        }
    }
}