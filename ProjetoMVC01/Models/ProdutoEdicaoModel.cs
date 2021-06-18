using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC01.Models
{
    public class ProdutoEdicaoModel
    {
        public Guid IdProduto { get; set; }

        [MinLength(6, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage ="Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por favor, informe o preço do produto.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage ="Por favor, informe a quantidade de produtos")]
        public int? Quantidade { get; set; }
    }
}
