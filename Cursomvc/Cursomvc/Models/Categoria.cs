using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cursomvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "O campo Descrição é Obrigatório")]
        //[Range(1, 50, ErrorMessage = "A Descricao deve estar entre 1 a 40 caracteres")]
        public string Descricao {get; set;}

        public List<Produto> Produtos { get; set; }

    }
}
