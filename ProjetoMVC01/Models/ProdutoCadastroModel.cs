using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC01.Models
{
    public class ProdutoCadastroModel
    {
        [MinLength(6, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage ="Por favor, informe no máxio{1} caracteres.")]

        [Required(ErrorMessage =("Por favor, informe o nome do produto."))]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por favor, informe o preco do produto.")]
        public double? Preco { get; set; }

        [Required(ErrorMessage ="Por favor, informe a quantidade do produto.")]
        public int? Quantidade { get; set; }

    }
}
