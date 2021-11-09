using System.ComponentModel.DataAnnotations;

namespace ProvaCandidato.Models
{
    public class Cidade
    {
        [Key]

        public int Codigo { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string nome { get; set; }

    }
    public enum Nome : int { Londrina = 1, Paranagua = 2, Curitiba = 3, FozdoIguaçu = 4 }
}