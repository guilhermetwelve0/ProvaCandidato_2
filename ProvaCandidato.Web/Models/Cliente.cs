using System;
using System.ComponentModel.DataAnnotations;

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
    public class AbstractValidator<Cliente>
    {
        private RuleFor(Cliente => Cliente.data_atual)
    	.NotEmpty().WithMessage("campo obrigatório")
         .LessThan(p => DateTime.Now).WithMessage("a data deve estar no passado");
    }


}