using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaCandidato.Models
{
	public class Cliente
	{
		[Key]
		public int Codigo { get; set; }
		[Required]
		[MaxLength(50)]
		[MinLength(3)]
		public string nome { get; set; }

		[Display(Name = "data de nascimento")]
		[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
		public DateTime? data_nascimento { get; set; }

		[Display(Name = "data atual")]
		[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
		public DateTime? data_atual { get; set; }
		

		public int codigo_cidade { get; set; }


	}
}