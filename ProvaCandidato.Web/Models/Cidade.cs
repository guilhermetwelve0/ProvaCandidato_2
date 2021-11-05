using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
}