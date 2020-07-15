using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cursomvc.Models
{
    public class Produto
    {
	

			public int Id { get; set; }
		    [Display(Name = "Descrição")]
			[Required(ErrorMessage = "O campo Descrição é Obrigatório")]
			//[Range(1, 50, ErrorMessage = "A Descricao deve estar entre 1 a 50 caracteres")]
		    public string Descricao { get; set; }
		    [Range(1, 50, ErrorMessage = "A quantidade deve estar entre 1 a 50")] 
			public int Quantidade { get; set; }
			public int CategoriaId { get; set; }
			public Categoria Categoria { get; set; }
		
	}
}
